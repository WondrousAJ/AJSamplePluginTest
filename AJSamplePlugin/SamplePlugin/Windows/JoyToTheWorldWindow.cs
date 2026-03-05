using Dalamud.Bindings.ImGui;
using Dalamud.Interface.Windowing;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SamplePlugin.Windows;

public class JoyToTheWorldWindow : Window, IDisposable
{
    public JoyToTheWorldWindow(Plugin plugin) : base("Joy to the World by Isaac Watts###With a constant ID")
    {
        SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(375, 330),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };
    }

    public void Dispose(){}

    public override void Draw()
    {
        ImGui.Text("Joy to the world; the Lord is come;" +
            "\nLet Earth receive her King;" +
            "\nLet ev'ry heart prepare him room," +
            "\nAnd heav'n and nature sing!\n\n");
        ImGui.Text("Joy to the Earth, the Savior reigns;");
        ImGui.Text("Our mortal songs employ,");
        ImGui.Text("While fields and floods, rocks, hills and plains,");
        ImGui.Text("Repeat the sounding joy.");
    }
}
