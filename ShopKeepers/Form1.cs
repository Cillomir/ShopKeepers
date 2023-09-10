/* **************************************************
* ShopKeepers v0.2.0
* Author: Joel Leckie
* Created: Sep. 2023
* 
* A custom shop tracker for tabletop games
*  v0.1.0 - Created shop form, shop class, and character
*           class.
************************************************** */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopKeepers
{
    public partial class Form1 : Form
    {
        internal List<item> ShopItems;

        public Form1()
        {
            InitializeComponent();
            ShopItems = new List<item>();
            ShopItems.Add(new item("Flask", 20, coinType.Gold, 2,
                "Something", new List<string> { "One", "Two", "Three" }));
            shopSource.DataSource = ShopItems;
            shopSource.ResetBindings(true);
            LoadShopGrid();

            //ShopItems.Add(new item("Flask", 20, coinType.Gold, 2,
            //    "Something", new List<string> { "One", "Two", "Three" }));
            //shopGridView.DataSource = shopSource;
        }

        private void LoadShopGrid()
        {
            shopGridView.Columns.Clear();
            DataGridViewColumn column;
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Name";
            column.Width = 144;
            shopGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Category";
            column.Name = "Category";
            column.Width = 112;
            shopGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cost";
            column.Name = "Cost";
            column.Width = 48;
            column.DividerWidth = 0;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            shopGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CoinType";
            //column.Name = "Coinage";
            column.Width = 24;
            column.DividerWidth = 0;
            shopGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Weight";
            column.Name = "Weight";
            column.Width = 48;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            shopGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DividerWidth = 0;
            column.Width = 24;
            column.ReadOnly = true;
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            cell.Value = "lbs";
            column.CellTemplate = cell;
            shopGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Description";
            column.Name = "Description";
            column.Width = 256 + 64;
            shopGridView.Columns.Add(column);

        }
    }
}
