using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

#pragma warning disable 1591

namespace GLFW
{
    /// <summary>
    ///     Represents the state of a gamepad.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GamePadState
    {
        [InlineArray(15)]
        public struct GamePadStateButtons
        {
            public InputState Element;
        }

        public readonly GamePadStateButtons States;

        [InlineArray(7)]
        public struct GamePadStateAxes
        {
            public float Element;
        }

        public readonly GamePadStateAxes Axes;

        /// <summary>
        ///     Gets the state of the specified <paramref name="button" />.
        /// </summary>
        /// <param name="button">The button to retrieve the state of.</param>
        /// <returns>The button state, either <see cref="InputState.Press" /> or <see cref="InputState.Release" />.</returns>
        public InputState GetButtonState(GamePadButton button) { return States[(int) button]; }

        /// <summary>
        ///     Gets the value of the specified <paramref name="axis" />.
        /// </summary>
        /// <param name="axis">The axis to retrieve the value of.</param>
        /// <returns>The axis value, in the range of <c>-1.0</c> and <c>1.0</c> inclusive.</returns>
        public float GetAxis(GamePadAxis axis) { return Axes[(int) axis]; }
    }
}