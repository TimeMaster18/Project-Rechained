﻿using SingleplayerLauncher.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class ComboBoxHelper<T>
{
    private ToolTip toolTip;
    private Dictionary<string, T> items;
    private Func<T, string> getToolTipText;
    private Action<Graphics, Rectangle, T> drawItemShape;

    public ComboBoxHelper(Dictionary<string, T> items, Func<T, string> getToolTipText, Action<Graphics, Rectangle, T> drawItemShape)
    {
        toolTip = new ToolTip();
        this.items = items;
        this.getToolTipText = getToolTipText;
        this.drawItemShape = drawItemShape;
    }

    public void InitializeComboBox(ComboBox comboBox)
    {
        comboBox.DrawMode = DrawMode.OwnerDrawFixed;
        comboBox.DrawItem += ComboBox_DrawItem;
        comboBox.DropDownClosed += ComboBox_DropDownClosed;
        comboBox.MouseLeave += ComboBox_MouseLeave;
        comboBox.LostFocus += ComboBox_LostFocus;
    }

    private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
    {
        ComboBox comboBox = (ComboBox)sender;

        if (e.Index < 0) { return; }

        string itemName = comboBox.GetItemText(comboBox.Items[e.Index]);
        if (!items.TryGetValue(itemName, out T item))
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

        if (drawItemShape != null)
        {
            // Draw the shape with the appropriate item
            drawItemShape(e.Graphics, e.Bounds, item);
        }

        // Draw the item text
        using (Brush brush = new SolidBrush((e.State & DrawItemState.Selected) == DrawItemState.Selected ? SystemColors.HighlightText : SystemColors.ControlText))
        {
            int xPadding = drawItemShape != null ? 25 : 0;
            e.Graphics.DrawString(itemName, e.Font, brush, e.Bounds.X + xPadding, e.Bounds.Y);
        }

        // Draw the focus rectangle if needed
        if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
        {
            e.DrawFocusRectangle();
        }

        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        {
            string toolTipText = getToolTipText(item);
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
}

public class TraitComboBoxHelper : ComboBoxHelper<Trait>
{
    public TraitComboBoxHelper(Dictionary<string, Trait> traits)
        : base(traits, GetToolTipText, DrawItemShape)
    {
    }

    private static string GetToolTipText(Trait trait)
    {
        return $"{trait.Name}\n\n{trait.Description}\n\nMatching Bonus: {trait.MatchingBonusTrait.Description}";
    }

    private static void DrawItemShape(Graphics g, Rectangle bounds, Trait trait)
    {
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

        using (Brush brush = new SolidBrush(shapeColor))
        {
            drawShape(g, bounds);
        }
    }

    private static void DrawTriangle(Graphics g, Rectangle bounds)
    {
        Point[] points = new Point[]
        {
            new Point(bounds.X + 10, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 20, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 15, bounds.Y + bounds.Height - 15)
        };
        g.FillPolygon(Brushes.Gold, points);
    }

    private static void DrawDiamond(Graphics g, Rectangle bounds)
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

    private static void DrawPentagon(Graphics g, Rectangle bounds)
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

    private static void DrawRectangle(Graphics g, Rectangle bounds)
    {
        g.FillRectangle(Brushes.Gray, bounds);
    }
}


public class SlotItemComboBoxHelper : ComboBoxHelper<SlotItem>
{
    public SlotItemComboBoxHelper(Dictionary<string, SlotItem> slotitems)
        : base(slotitems, GetToolTipText, null)
    {
    }

    private static string GetToolTipText(SlotItem slotItem)
    {
        return $"{slotItem.Name}\n\n{slotItem.Description}";
    }
}


public class TrapPartComboBoxHelper : ComboBoxHelper<TrapPart>
{
    public TrapPartComboBoxHelper(Dictionary<string, TrapPart> trapParts)
        : base(trapParts, GetToolTipText, null)
    {
    }

    private static string GetToolTipText(TrapPart trapPart)
    {
        return $"{trapPart.Name}\n\n{trapPart.Description}";
    }
}