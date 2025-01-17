// ------------------------------------------------------------
// The code in this repository code was written by Lee Campbell, as a
// derived work from the original Java by Gil Tene of Azul Systems and
// Michael Barker, and released to the public domain, as explained
// at http://creativecommons.org/publicdomain/zero/1.0/
// ------------------------------------------------------------

// This file isn't generated, but this comment is necessary to exclude it from StyleCop analysis.
// <auto-generated/>

using System.Diagnostics;

namespace HdrHistogram
{
    /// <summary>
    /// Helper methods to get time periods based in system stopwatch units.
    /// </summary>
    internal static class TimeStamp
    {
        /// <summary>
        /// Return a <see cref="long"/> representing the number system timer ticks that occur over the provided number of seconds.
        /// </summary>
        /// <param name="seconds">A number seconds to represent.</param>
        /// <returns>The number of system timer ticks that represent the <paramref name="seconds"/>.</returns>
        public static long Seconds(long seconds)
        {
            return Stopwatch.Frequency * seconds;
        }

        /// <summary>
        /// Return a <see cref="long"/> representing the number system timer ticks that occur over the provided number of minutes.
        /// </summary>
        /// <param name="minutes">A number minutes to represent.</param>
        /// <returns>The number of system timer ticks that represent the <paramref name="minutes"/>.</returns>
        public static long Minutes(long minutes)
        {
            return minutes * Seconds(60);
        }

        /// <summary>
        /// Return a <see cref="long"/> representing the number system timer ticks that occur over the provided number of hours.
        /// </summary>
        /// <param name="hours">A number hours to represent.</param>
        /// <returns>The number of system timer ticks that represent the <paramref name="hours"/>.</returns>
        public static long Hours(int hours)
        {
            return hours * Minutes(60);
        }
    }
}