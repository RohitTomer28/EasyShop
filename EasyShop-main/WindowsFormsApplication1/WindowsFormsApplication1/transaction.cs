using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class transaction : Form
    {
        int y = 19;
        OracleConnection conn;

        // list to store the ids of the items
        List<String> ids = new List<String>();

        public transaction()
        {
            InitializeComponent();
            conn = new OracleConnection("Data Source=127.0.0.1:1521;Persist Security Info=True;User ID=system;Password=1234");
            conn.Open();
        }


        private void plusItem(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String name = btn.Name;
            String id = name.Substring(2);
            Label lbl = (Label)panel1.Controls["Q" + id];

            int quantity = Int32.Parse(lbl.Text);
            quantity++;
            lbl.Text = quantity.ToString();
            addCost(Int32.Parse(((Label)panel1.Controls["P" + id]).Text));
        }

        private void addCost(int price)
        {
            cost.Text = (Int32.Parse(cost.Text) + price).ToString();
        }

        private void minusItem(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String name = btn.Name;
            String id = name.Substring(2);

            Label lbl = (Label)panel1.Controls["Q" + id];
            int quantity = Int32.Parse(lbl.Text);
            quantity--;
            lbl.Text = quantity.ToString();
            int y_pos = lbl.Location.Y;
            int price = Int32.Parse(((Label)panel1.Controls["P" + id]).Text);
            addCost(-price);
            if (quantity == 0)
            {
                Label lbl1 = (Label)panel1.Controls["L" + id];
                Label lbl2 = (Label)panel1.Controls["P" + id];
                Label lbl3 = (Label)panel1.Controls["Q" + id];
                Button btn1 = (Button)panel1.Controls["Mi" + id];
                Button btn2 = (Button)panel1.Controls["Pl" + id];

                panel1.Controls.Remove(lbl1);
                panel1.Controls.Remove(lbl2);
                panel1.Controls.Remove(lbl3);
                panel1.Controls.Remove(btn1);
                panel1.Controls.Remove(btn2);
            }
            else
            {
                return;
            }

            ids.Remove(id);

            // go through all controls in panel1 and adjust the y position of each control if y is greater than the y position of the removed control

            foreach (Control c in panel1.Controls)
            {
                if (c.Location.Y > y_pos)
                {
                    c.Location = new Point((int)(c.Location.X), (int)((c.Location.Y - (40 * dy))));
                }
            }
            y -= 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // generate random order id
            Random random = new Random();
            int order_id = random.Next(10000, 99999);
            String mode_of_payment = comboBox1.Text;
            String total_cost = cost.Text;
            String cust_id;


            // take phone_number from textBox2, get the customer id from the customer_details table using phone_number and save it in cust_id
            // if the phone number is not found, display messagebox
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = conn;
            oracleCommand.CommandText = "SELECT customer_id FROM customer_details WHERE phone_number = :phone_number";
            oracleCommand.Parameters.Add("phone_number", textBox2.Text);

            OracleDataReader reader = oracleCommand.ExecuteReader();
            if (reader.Read())
            {
                cust_id = reader.GetString(0);
            }
            else
            {
                MessageBox.Show("Customer not found. Enter phone number");
                return;
            }

            // create a feedback form and pass the order_id and cust_id to it
            coupon c = new coupon();
            c.cust = cust_id;
            c.order = order_id.ToString();
            c.t = double.Parse(total_cost);

            // insert order into the transaction table
            oracleCommand.CommandText = "INSERT INTO transactions VALUES ('" + cust_id + "', '" + order_id + "', " + total_cost + ")";
            oracleCommand.ExecuteNonQuery();

            // insert order_id, customer_id, mode_of_payment into the places_order table
            oracleCommand.CommandText = "INSERT INTO places_order VALUES ('" + order_id + "', '" + cust_id + "', '" + mode_of_payment + "')";
            oracleCommand.ExecuteNonQuery();


            // insert all items in the order into the order_details table
            foreach (String id in ids)
            {
                Label lbl = (Label)panel1.Controls["Q" + id];

                int quantity = Int32.Parse(lbl.Text);

                String order_id_str = order_id.ToString();

                oracleCommand.CommandText = "INSERT INTO order_details VALUES ('" + order_id_str + "', '" + id + "', " + quantity + ")";
                oracleCommand.ExecuteNonQuery();

                //decrease the quantity of the item in the stock table
                try
                {
                    oracleCommand.CommandText = "UPDATE stock SET quantity = quantity - " + quantity + " WHERE item_id = '" + id + "'";
                    oracleCommand.ExecuteNonQuery();

                    //if new quantity is 0, throw an error
                    oracleCommand.CommandText = "SELECT quantity FROM stock WHERE item_id = '" + id + "'";
                    OracleDataReader reader1 = oracleCommand.ExecuteReader();
                    reader1.Read();
                    int new_quantity = reader1.GetInt32(0);
                    if (new_quantity < 0)
                    {
                        MessageBox.Show("Not enough stock for item " + id);
                        return;
                    }
                    MessageBox.Show("Cust: " + c.cust + "\nOrder: " + c.order);
                    MessageBox.Show("Thank you \n refno: " + order_id);

                    // open coupon form
                    c.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not enough stock!");
                }
            }
        }
        float dx = 1;
        float dy = 1;
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            { 
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = conn;
            oracleCommand.CommandText = "SELECT * FROM item_details WHERE item_id = :id";
            oracleCommand.Parameters.Add("id", textBox1.Text);

            OracleDataReader reader = oracleCommand.ExecuteReader();
            reader.Read();
            String ItemID = reader.GetString(0);
            String ItemName = reader.GetString(1);
            String ItemPrice = reader.GetString(3);

            int scroll = panel1.VerticalScroll.Value;
            int y_pos = y - scroll;

            // if the item is already in the list, increase the quantity by 1
            if (ids.Contains(ItemID))
            {
                Label lblf = (Label)panel1.Controls["Q" + ItemID];
                int quantityf = Int32.Parse(lblf.Text);
                quantityf++;
                lblf.Text = quantityf.ToString();
                addCost(Int32.Parse(ItemPrice));
                return;
            }


            Label lbl = new Label
            {
                BackColor = Color.White,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point((int)(23 * dx), (int)( y_pos * dy)),
                Padding = new System.Windows.Forms.Padding(3, 0, 3, 0),
                Name = "L" + ItemID,
                AutoSize = false,
                Size = new System.Drawing.Size((int)( 484 * dx), (int)(30 * dy)),
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Text = ItemName
            };

            Label price = new Label
            {
                BackColor = Color.White,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point((int)(530 * dx), (int)( y_pos * dy)),
                Padding = new System.Windows.Forms.Padding(3, 0, 3, 0),
                Name = "P" + ItemID,
                AutoSize = false,
                Size = new System.Drawing.Size((int)(54 * dx), (int)(30 * dy)),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Text = ItemPrice
            };

            Button min = new Button
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point((int)(599 * dx), (int)(y_pos * dy)),
                Name = "Mi" + ItemID,
                Size = new System.Drawing.Size((int)(42 * dx), (int)(29 * dy)),
                Text = "-",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                UseVisualStyleBackColor = true
            };

            min.Click += new EventHandler(minusItem);

            Button plus = new Button
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point((int)(674 * dx), (int)(y_pos * dy)),
                Name = "Pl" + ItemID,
                Size = new System.Drawing.Size((int)(40 * dx), (int)(29 * dy)),
                Text = "+",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                UseVisualStyleBackColor = true,

            };

            // add event handler to plus button
            plus.Click += new EventHandler(plusItem);

            Label quantity = new Label
            {
                BackColor = Color.Transparent,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point((int)(640 * dx), (int)(y_pos * dy)),
                Padding = new System.Windows.Forms.Padding(3, 0, 3, 0),
                Name = "Q" + ItemID,
                AutoSize = false,
                Size = new System.Drawing.Size((int)(36 * dx), (int)(29 * dy)),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Text = "1"
            };


            ids.Add(ItemID);

            addCost(Int32.Parse(ItemPrice));


            panel1.Controls.Add(lbl);
            panel1.Controls.Add(price);

            panel1.Controls.Add(min);
            panel1.Controls.Add(plus);
            panel1.Controls.Add(quantity);

            y += 40;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("There is a problem with the Oracle Connection " + ex.Message);
            }
            
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Item not found!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void transaction_Load(object sender, EventArgs e)
        {


            Form f = (Form)sender;

            int resy = f.Size.Height;
            int resx = f.Size.Width;

            f.WindowState = FormWindowState.Maximized;

            dx = f.Size.Width / (float)resx;
            dy = f.Size.Height / (float)resy;



            Control s = GetNextControl(f, true);

            while (s != null)
            {

                Size size = new Size((int)(s.Size.Width * dx), (int)((s.Size.Height) * dy));


                int newx = (int)(s.Location.X * dx);
                int newy = (int)((s.Location.Y + 12)  * dy);

                Point p = new Point(newx, newy);


                s.Size = size;
                s.Location = p;
                s = f.GetNextControl(s, true);


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
