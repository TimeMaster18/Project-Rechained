using SingleplayerLauncher.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class ComboBoxHelper
{
    private ToolTip toolTip;
    private Dictionary<string, Trait> traits;

    public ComboBoxHelper(Dictionary<string, Trait> traits)
    {
        toolTip = new ToolTip();
        this.traits = traits;
    }

    public void InitializeComboBox(ComboBox comboBox)
    {
        comboBox.DrawMode = DrawMode.OwnerDrawFixed;
        comboBox.DrawItem += ComboBox_DrawItem;
        comboBox.DropDownClosed += ComboBox_DropDownClosed;
        comboBox.MouseLeave += ComboBox_MouseLeave;
        comboBox.LostFocus += ComboBox_LostFocus; // Add this line
    }

    private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
    {
        ComboBox comboBox = (ComboBox)sender;

        if (e.Index < 0) { return; }

        string itemName = comboBox.GetItemText(comboBox.Items[e.Index]);
        if (!traits.TryGetValue(itemName, out Trait trait))
            return;

        // Draw the background
        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        {
            e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
        }
        else
        {
            e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
        }

        // Determine the shape and color based on the MatchingSlot
        Color shapeColor;
        Action<Graphics, Rectangle> drawShape;

        switch (trait.MatchingSlot)
        {
            case Trait.TRIANGLE_BONUS_SLOT:
                shapeColor = Color.Yellow;
                drawShape = DrawTriangle;
                break;
            case Trait.DIAMOND_BONUS_SLOT:
                shapeColor = Color.Blue;
                drawShape = DrawDiamond;
                break;
            case Trait.PENTAGON_BONUS_SLOT:
                shapeColor = Color.Green;
                drawShape = DrawPentagon;
                break;
            default:
                shapeColor = Color.Black;
                drawShape = DrawRectangle; // Default shape
                break;
        }

        // Draw the shape with the appropriate color
        using (Brush brush = new SolidBrush(shapeColor))
        {
            drawShape(e.Graphics, e.Bounds);
        }

        // Draw the item text
        using (Brush brush = new SolidBrush((e.State & DrawItemState.Selected) == DrawItemState.Selected ? SystemColors.HighlightText : SystemColors.ControlText))
        {
            e.Graphics.DrawString(itemName, e.Font, brush, e.Bounds.X + 25, e.Bounds.Y);
        }

        // Draw the focus rectangle if needed
        if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
        {
            e.DrawFocusRectangle();
        }

        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        {
            string toolTipText = GetToolTipText(trait);
            toolTip.Show(toolTipText, comboBox, e.Bounds.Right, e.Bounds.Bottom);
        }
    }

    private void ComboBox_DropDownClosed(object sender, EventArgs e)
    {
        toolTip.Hide((Control)sender);
        ((ComboBox)sender).Focus();
    }

    private void ComboBox_MouseLeave(object sender, EventArgs e)
    {
        toolTip.Hide((Control)sender);
    }

    private void ComboBox_LostFocus(object sender, EventArgs e)
    {
        toolTip.Hide((Control)sender);
    }

    private string GetToolTipText(Trait trait)
    {
        return $"{trait.Name}\n\n{trait.Description}\n\nMatching Bonus: {trait.MatchingBonusTrait.Description}";
    }

    private void DrawTriangle(Graphics g, Rectangle bounds)
    {
        Point[] points = new Point[]
        {
            new Point(bounds.X + 10, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 20, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 15, bounds.Y + bounds.Height - 15)
        };
        g.FillPolygon(Brushes.Gold, points);
    }

    private void DrawDiamond(Graphics g, Rectangle bounds)
    {
        Point[] points = new Point[]
        {
            new Point(bounds.X + 15, bounds.Y + bounds.Height - 15),
            new Point(bounds.X + 20, bounds.Y + bounds.Height - 10),
            new Point(bounds.X + 15, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 10, bounds.Y + bounds.Height - 10)
        };
        g.FillPolygon(Brushes.LightSkyBlue, points);
    }

    private void DrawPentagon(Graphics g, Rectangle bounds)
    {
        Point[] points = new Point[]
        {
            new Point(bounds.X + 15, bounds.Y + bounds.Height - 15),
            new Point(bounds.X + 20, bounds.Y + bounds.Height - 10),
            new Point(bounds.X + 18, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 12, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 10, bounds.Y + bounds.Height - 10)
        };
        g.FillPolygon(Brushes.LightGreen, points);
    }

    private void DrawRectangle(Graphics g, Rectangle bounds)
    {
        g.FillRectangle(Brushes.Gray, bounds);
    }
}
