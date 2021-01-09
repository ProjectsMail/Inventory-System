using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Apple_textBox.Text = "0";
            Banana_textBox.Text = "0";
            Cherry_textBox.Text = "0";
            Grape_textBox.Text = "0";
            Mango_textBox.Text = "0";
            Orange_textBox.Text = "0";
            Tomato_textBox.Text = "0";
            Cucumber_textBox.Text = "0";
            Potatoes_textBox.Text = "0";
            Peas_textBox.Text = "0";
            Onions_textBox.Text = "0";
            Spinach_textBox.Text = "0";
            Milkshake_textBox.Text = "0";
            VanillaCone_textBox.Text = "0";
            ClassicVanilla_textBox.Text = "0";
            VanillaMilkshake_textBox.Text = "0";
            ChocolateMilkshake_textBox.Text = "0";
            StrawberryMilkshake_textBox.Text = "0";
            FruitsCost_textBox.Text = "0";
            VegetablesCost_textBox.Text = "0";
            MilkshakeCost_textBox.Text = "0";
            Tax_textBox.Text = "0";
            Subtotal_textBox.Text = "0";
            Total_textBox.Text = "0";
        }

        private void Total_button_Click(object sender, EventArgs e)
        {
            Parent_Items cost_of_items = new Parent_Items();
            double itax, isubtotal, itotal;

            cost_of_items.apple = cost_of_items.apple_price * Double.Parse(Apple_textBox.Text);
            cost_of_items.banana = cost_of_items.banana_price * Double.Parse(Banana_textBox.Text);
            cost_of_items.cherry = cost_of_items.cherry_price * Double.Parse(Cherry_textBox.Text);
            cost_of_items.grape = cost_of_items.grape_price * Double.Parse(Grape_textBox.Text);
            cost_of_items.mango = cost_of_items.mango_price * Double.Parse(Mango_textBox.Text);
            cost_of_items.orange = cost_of_items.orange_price * Double.Parse(Orange_textBox.Text);
            cost_of_items.tomato = cost_of_items.tomato_price * Double.Parse(Tomato_textBox.Text);
            cost_of_items.cucumber = cost_of_items.cucumber_price * Double.Parse(Cucumber_textBox.Text);
            cost_of_items.potatoes = cost_of_items.potatoes_price * Double.Parse(Potatoes_textBox.Text);
            cost_of_items.peas = cost_of_items.peas_price * Double.Parse(Peas_textBox.Text);
            cost_of_items.onions = cost_of_items.onions_price * Double.Parse(Onions_textBox.Text);
            cost_of_items.spinach = cost_of_items.spinach_price * Double.Parse(Spinach_textBox.Text);
            cost_of_items.milkshake = cost_of_items.milkshake_price * Double.Parse(Milkshake_textBox.Text);
            cost_of_items.vanilla_cone = cost_of_items.vanilla_cone_price * Double.Parse(VanillaCone_textBox.Text);
            cost_of_items.classic_vanilla = cost_of_items.classic_vanilla_price * Double.Parse(ClassicVanilla_textBox.Text);
            cost_of_items.vanilla_milkshake = cost_of_items.vanilla_milkshake_price * Double.Parse(VanillaMilkshake_textBox.Text);
            cost_of_items.chocolate_milkshake = cost_of_items.chocolate_milkshake_price * Double.Parse(ChocolateMilkshake_textBox.Text);
            cost_of_items.strawberry_milkshake = cost_of_items.strawberry_milkshake_price * Double.Parse(Banana_textBox.Text);

            isubtotal = cost_of_items.GetAmount();
            itax = cost_of_items.GetTax();
            itotal = itax + isubtotal;

            String Total = String.Format("{0:C}", itotal);
            Total_textBox.Text = Total;
            String subtotal = String.Format("{0:C}", isubtotal);
            Subtotal_textBox.Text = subtotal;
            String Tax = String.Format("{0:C}", itax);
            Tax_textBox.Text = Tax;

            String Fruits = String.Format("{0:C}", cost_of_items.fruits_cost);
            FruitsCost_textBox.Text = Fruits;
            String Vegetables = String.Format("{0:C}", cost_of_items.vegetables_cost);
            VegetablesCost_textBox.Text = Vegetables;
            String Milkshake = String.Format("{0:C}", cost_of_items.milkshake_cost);
            MilkshakeCost_textBox.Text = Milkshake;


        }

        private void Numbers_Only(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
