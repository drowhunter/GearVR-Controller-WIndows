﻿using System.Collections.Generic;

namespace GearVR_Controller
{
    public class KeyCodeCollection
    {
        public static Dictionary<string, short> GetKeyCodes()
        {
            Dictionary<string, short> keyCode = new()
            {
                { "Toggle", 0 },
                { "Mouse left button", 0 },
                { "Mouse right button", 0 },
                { "Mouse middle button", 0 },
                { "X1 mouse button", 0x0001 },
                { "X2 mouse button", 0x0002 },
                { "Control-break processing", 0x03 },
                { "BACKSPACE", 0x08 },
                { "TAB", 0x09 },
                { "CLEAR", 0x0C },
                { "ENTER", 0x0D },
                { "SHIFT", 0x10 },
                { "CTRL", 0x11 },
                { "ALT", 0x12 },
                { "PAUSE ", 0x13 },
                { "CAPS LOCK", 0x14 },
                { "ESC ", 0x1B },
                { "SPACEBAR", 0x20 },
                { "PAGE UP", 0x21 },
                { "PAGE DOWN", 0x22 },
                { "END", 0x23 },
                { "HOME", 0x24 },
                { "LEFT ARROW", 0x25 },
                { "UP ARROW", 0x26 },
                { "RIGHT ARROW", 0x27 },
                { "DOWN ARROW", 0x28 },
                { "SELECT", 0x29 },
                { "PRINT", 0x2A },
                { "EXECUTE", 0x2B },
                { "PRINT SCREEN", 0x2C },
                { "INS", 0x2D },
                { "DEL", 0x2E },
                { "HELP", 0x2F },
                { "0", 0x30 },
                { "1", 0x31 },
                { "2", 0x32 },
                { "3", 0x33 },
                { "4", 0x34 },
                { "5", 0x35 },
                { "6", 0x36 },
                { "7", 0x37 },
                { "8", 0x38 },
                { "9", 0x39 },
                { "A", 0x41 },
                { "B", 0x42 },
                { "C", 0x43 },
                { "D", 0x44 },
                { "E", 0x45 },
                { "F", 0x46 },
                { "G", 0x47 },
                { "H", 0x48 },
                { "I", 0x49 },
                { "J", 0x4A },
                { "K", 0x4B },
                { "L", 0x4C },
                { "M", 0x4D },
                { "N", 0x4E },
                { "O", 0x4F },
                { "P", 0x50 },
                { "Q", 0x51 },
                { "R", 0x52 },
                { "S", 0x53 },
                { "T", 0x54 },
                { "U", 0x55 },
                { "V", 0x56 },
                { "W", 0x57 },
                { "X", 0x58 },
                { "Y", 0x59 },
                { "Z", 0x5A },
                { "Left Windows", 0x5B },
                { "Right Windows key", 0x5C },
                { "Applications", 0x5D },
                { "Computer Sleep", 0x5F },
                { "Numeric keypad 0", 0x60 },
                { "Numeric keypad 1", 0x61 },
                { "Numeric keypad 2", 0x62 },
                { "Numeric keypad 3", 0x63 },
                { "Numeric keypad 4", 0x64 },
                { "Numeric keypad 5", 0x65 },
                { "Numeric keypad 6", 0x66 },
                { "Numeric keypad 7", 0x67 },
                { "Numeric keypad 8", 0x68 },
                { "Numeric keypad 9", 0x69 },
                { "Multiply", 0x6A },
                { "Add", 0x6B },
                { "Separator", 0x6C },
                { "Subtract", 0x6D },
                { "Decimal", 0x6E },
                { "Divide", 0x6F },
                { "F1", 0x70 },
                { "F2", 0x71 },
                { "F3", 0x72 },
                { "F4", 0x73 },
                { "F5", 0x74 },
                { "F6", 0x75 },
                { "F7", 0x76 },
                { "F8", 0x77 },
                { "F9", 0x78 },
                { "F10", 0x79 },
                { "F11", 0x7A },
                { "F12", 0x7B },
                { "F13", 0x7C },
                { "F14", 0x7D },
                { "F15", 0x7E },
                { "F16", 0x7F },
                { "F17", 0x80 },
                { "F18", 0x81 },
                { "F19", 0x82 },
                { "F20", 0x83 },
                { "F21", 0x84 },
                { "F22", 0x85 },
                { "F23", 0x86 },
                { "F24", 0x87 },
                { "NUM LOCK", 0x90 },
                { "SCROLL LOCK", 0x91 },
                { "Left SHIFT", 0xA0 },
                { "Right SHIFT", 0xA1 },
                { "Left CONTROL", 0xA2 },
                { "Right CONTROL", 0xA3 },
                { "Left MENU", 0xA4 },
                { "Right MENU", 0xA5 },
                { "Browser Back", 0xA6 },
                { "Browser Forward", 0xA7 },
                { "Browser Refresh", 0xA8 },
                { "Browser Stop", 0xA9 },
                { "Browser Search", 0xAA },
                { "Browser Favorites", 0xAB },
                { "Browser Start and Home", 0xAC },
                { "Volume Mute", 0xAD },
                { "Volume Down", 0xAE },
                { "Volume Up", 0xAF },
                { "Next Track", 0xB0 },
                { "Previous Track", 0xB1 },
                { "Stop Media", 0xB2 },
                { "Play/Pause Media", 0xB3 },
                { "Start Mail", 0xB4 },
                { "Select Media", 0xB5 },
                { "Start Application 1", 0xB6 },
                { "Start Application 2", 0xB7 },
                { ";:", 0xBA },
                { "+", 0xBB },
                { ",", 0xBC },
                { "-", 0xBD },
                { ".", 0xBE },
                { "/?", 0xBF },
                { "~", 0xC0 },
                { "[{", 0xDB },
                { "\\|", 0xDC },
                { "]}", 0xDD },
                { "single-quote/double-quote", 0xDE },
                { "Attn", 0xF6 },
                { "CrSel", 0xF7 },
                { "ExSel", 0xF8 },
                { "Erase EOF", 0xF9 },
                { "Play", 0xFA },
                { "Zoom", 0xFB },
                { "PA1", 0xFD },
                { "Clear", 0xFE },
                { "--Don't Use This Mouse left button DOWN", 0x0002 },
                { "--Don't Use This Mouse left button UP", 0x0004 },
                { "--Don't Use This Mouse right button DOWN", 0x0008 },
                { "--Don't Use This Mouse right button UP", 0x0010 },
                { "--Don't Use This Mouse middle button DOWN", 0x0020 },
                { "--Don't Use This Mouse middle button UP", 0x0040 },
                { "--Don't Use This X DOWN", 0x0080 },
                { "--Don't Use This X UP", 0x0100 },
                { "--Don't Use This Mouse wheel", 0x0800 }

            };
            return keyCode;
        }
    }
}
