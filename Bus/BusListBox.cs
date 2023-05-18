using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Bus
{
    internal class BusListBox : ListBox
    {
        public BusListBox() : base()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 64;
            BorderStyle = BorderStyle.None;
        }

        public Bus getSelectedBus()
        {
            if(SelectedIndex != -1)
            {
                return Items[SelectedIndex] as Bus;
            }
            return null;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {

            // Check if the current item is selected
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            if (e.Index >= 0 && e.Index < Items.Count)
            {
                // Get the item text
                string itemText = Items[e.Index].ToString();

                // Set the desired background and foreground colors
                Color backgroundColor = isSelected ? Color.Orange : SystemColors.Window;
                Color foregroundColor = SystemColors.ControlText;

                // Set the padding/margin values
                const int itemPadding = 1; // Set your desired padding/margin value here

                // Calculate the new item bounds with increased height
                Rectangle itemBounds = new Rectangle(
                    e.Bounds.Left,
                    e.Bounds.Top,
                    e.Bounds.Width,
                    ItemHeight
                );

                // Draw the background
                using (SolidBrush brush = new SolidBrush(backgroundColor))
                {
                    e.Graphics.FillRectangle(brush, itemBounds);
                }

                int imageSize = ItemHeight - 2 * itemPadding;
                Rectangle imageBounds = new Rectangle(
                    itemBounds.Left + itemPadding,
                    itemBounds.Top + itemPadding,
                    imageSize,
                    imageSize
                );

                Image image = Image.FromFile("./Resources/Images/bus48.png");
                e.Graphics.DrawImage(image, imageBounds);

                // Calculate the text bounds with padding
                Rectangle textBounds = new Rectangle(
                    itemBounds.Left + imageBounds.Width,
                    itemBounds.Top,
                    itemBounds.Width - 2 * itemPadding,
                    itemBounds.Height - 2 * itemPadding
                );

                // Set the text alignment options
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                };

                // Draw the item text
                using (SolidBrush brush = new SolidBrush(foregroundColor))
                {
                    e.Graphics.DrawString(itemText, e.Font, brush, textBounds, format);
                }
            }
        }
    }
}
