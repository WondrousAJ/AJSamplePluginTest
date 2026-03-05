using Dalamud.Game.Gui.ContextMenu;
using Dalamud.Plugin.Services;
using Lumina.Excel.Sheets;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePlugin;

public class ContextLizard : IContextMenu, IDisposable
{
    public event IContextMenu.OnMenuOpenedDelegate OnMenuOpened;

    public void AddMenuItem(ContextMenuType menuType, IMenuItem item)
    {
        //blah!
    }

    public bool RemoveMenuItem(ContextMenuType menuType, IMenuItem item)
    {
        throw new NotImplementedException();
    }

    public void Dispose() {}
}
