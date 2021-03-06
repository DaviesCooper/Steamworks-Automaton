﻿using GregsStack.InputSimulatorStandard.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSteamApp.Configuration
{
    public static class ConfigurationDefaults
    {
        /// <summary>
        /// Is the program by default in debug mode?
        /// </summary>
        public const bool DefaultIsDebug = false;

        /// <summary>
        /// Is the default keyboard layout azerty?
        /// </summary>
        public const bool DefaultIsAzerty = false;

        /// <summary>
        /// What is the default delay between inputs when doing a random input sequence?
        /// </summary>
        public const int DefaultRandomInputDelay = 50;

        /// <summary>
        /// What is the keycode used to skip cutscenes?
        /// </summary>
        public const VirtualKeyCode DefaultKeyCutsceneSkip = VirtualKeyCode.VK_X;

        /// <summary>
        /// Are we inputting random values?
        /// </summary>
        public const bool DefaultRandomRun = false;

        /// <summary>
        /// What is the probability of winning a common reward
        /// </summary>
        public const float DefaultCommonSuccessRate = 1f;

        /// <summary>
        /// What is the probability of winning a rare reward
        /// </summary>
        public const float DefaultRareSuccessRate = 1f;

        /// <summary>
        /// How long do we wait for the slot to be identified before exiting?
        /// </summary>
        public const int DefaultMaxTimeSlotNumberSeconds = 30;

        /// <summary>
        /// At what fuel amount do we stop running?
        /// </summary>
        public const int DefaultStopAtFuelAmount = 0;

        /// <summary>
        /// Should only natural fuel be spent?
        /// </summary>
        public const bool DefaultOnlyUseNaturalFuel = false;

        /// <summary>
        /// Should the app close itself on exit condition being met, or wait for user input?
        /// </summary>
        public const bool DefaultShouldAutoQuit = false;
    }
}
