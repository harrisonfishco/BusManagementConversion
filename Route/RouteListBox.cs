using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Route
{
    internal class RouteListBox : ListBox
    {
        public RouteListBox() : base()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 64;
            BorderStyle = BorderStyle.None;
        }

        public Route getSelectedRoute()
        {
            if(SelectedIndex != -1)
            {
                return Items[SelectedIndex] as Route;
            }
            return null;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            if(e.Index >= 0 && e.Index < Items.Count)
            {
                Route route = (Route)Items[e.Index];
                string itemText = "Route: " + route.getName() + " | Duration: " + route.getDuration() + " Min | Distance: " + route.getLength() + " mi";

                Color backgroundColor = isSelected ? Color.Orange : SystemColors.Window;
                Color foregroundColor = SystemColors.ControlText;

                const int itemPadding = 1;

                Rectangle itemBounds = new Rectangle(
                    e.Bounds.Left,
                    e.Bounds.Top,
                    e.Bounds.Width,
                    ItemHeight
                );

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

                Image image = Image.FromFile("./Resources/Images/route48.png");
                e.Graphics.DrawImage(image, imageBounds);

                Rectangle textBounds = new Rectangle(
                    itemBounds.Left + imageBounds.Width,
                    itemBounds.Top,
                    itemBounds.Width - 2 * itemPadding,
                    itemBounds.Height - 2 * itemPadding
                );

                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                };

                using(SolidBrush brush = new SolidBrush(foregroundColor))
                {
                    e.Graphics.DrawString(itemText, e.Font, brush, textBounds, format);
                }
            }
        }
    }
}
