﻿using Vanara.PInvoke;

using MicaForEveryone.Models;

namespace MicaForEveryone.Rules
{
    public interface IRule
    {
        bool IsApplicable(HWND windowHandle);
        TitlebarColorMode TitlebarColor { get; set; }
        BackdropType BackdropPreference { get; set; }
        bool ExtendFrameIntoClientArea { get; set; }
    }
}
