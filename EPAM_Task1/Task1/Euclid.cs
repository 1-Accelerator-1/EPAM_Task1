using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EPAM_Task1.Task1
{
    /// <summary>
    /// Class for calculating GCD with a different number of parameters (from 2 to 5).
    /// </summary>
    public class Euclid
    {
        private const string GCD_EUCLID_2_PARAMETERS = "GCD Euclid 2 parameters";
        private const string GCD_EUCLID_3_PARAMETERS = "GCD Euclid 3 parameters";
        private const string GCD_EUCLID_4_PARAMETERS = "GCD Euclid 4 parameters";
        private const string GCD_EUCLID_5_PARAMETERS = "GCD Euclid 5 parameters";
        private const string GCD_STAIN_2_PARAMETERS = "GCD Stain 2 parameters";
        private long _workingTimeEuclid2;
        private long _workingTimeEuclid3;
        private long _workingTimeEuclid4;
        private long _workingTimeEuclid5;
        private long _workingTimeStain2;

        /// <summary>
        /// The method calculates the GCD value for two numbers using the Euclidean algorithm and measures the time of the method.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>GCD</returns>
        public int GetGCDEuclid(int a, int b)
        {
            var watch = Stopwatch.StartNew();

            if (a == 0)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            watch.Stop();
            _workingTimeEuclid2 = watch.ElapsedMilliseconds;

            return a;
        }

        /// <summary>
        /// The method calculates the GCD value for three numbers using the Euclidean algorithm and measures the time of the method.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <returns>GCD</returns>
        public int GetGCDEuclid(int a, int b, int c)
        {
            var watch = Stopwatch.StartNew();

            var result = GetGCDEuclid(GetGCDEuclid(a, b), c);

            watch.Stop();
            _workingTimeEuclid3 = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// The method calculates the GCD value for four numbers using the Euclidean algorithm and measures the time of the method.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <param name="d">Fourth number</param>
        /// <returns>GCD</returns>
        public int GetGCDEuclid(int a, int b, int c, int d)
        {
            var watch = Stopwatch.StartNew();

            var result = GetGCDEuclid(GetGCDEuclid(GetGCDEuclid(a, b), c), d);

            watch.Stop();
            _workingTimeEuclid4 = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// The method calculates the GCD value for five numbers using the Euclidean algorithm and measures the time of the method.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <param name="d">Fourth number</param>
        /// <param name="e">Fifth number</param>
        /// <returns>GCD</returns>
        public int GetGCDEuclid(int a, int b, int c, int d, int e)
        {
            var watch = Stopwatch.StartNew();

            var result = GetGCDEuclid(GetGCDEuclid(GetGCDEuclid(GetGCDEuclid(a, b), c), d), e);

            watch.Stop();
            _workingTimeEuclid5 = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// The method calculates the GCD value for two numbers using the Stain algorithm and measures the time of the method.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>GCD</returns>
        public int GetGCDStain(int a, int b)
        {
            var watch = Stopwatch.StartNew();

            a = Math.Abs(a);
            b = Math.Abs(b);

            int shift = 0;

            if (a == 0)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }

            while (((a | b) & 1) == 0)
            {
                shift++;
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
            {
                a >>= 1;
            }

            do
            {
                while ((b & 1) == 0)
                {
                    b >>= 1;
                }

                if (a > b)
                {
                    int t = b; b = a; a = t;
                }

                b -= a;
            } while (b != 0);

            watch.Stop();
            _workingTimeStain2 = watch.ElapsedMilliseconds;

            return a << shift;
        }

        /// <summary>
        /// The method prepares data for building a histogram comparing the time it takes to find a solution by each of methods.
        /// </summary>
        /// <returns>Dictionary: key = "method name", value = "time"</returns>
        public Dictionary<string, long> GetDataForHistogram()
        {
            var dataForHistogram = new Dictionary<string, long>();

            dataForHistogram.Add(GCD_EUCLID_2_PARAMETERS, _workingTimeEuclid2);
            dataForHistogram.Add(GCD_EUCLID_3_PARAMETERS, _workingTimeEuclid3);
            dataForHistogram.Add(GCD_EUCLID_4_PARAMETERS, _workingTimeEuclid4);
            dataForHistogram.Add(GCD_EUCLID_5_PARAMETERS, _workingTimeEuclid5);
            dataForHistogram.Add(GCD_STAIN_2_PARAMETERS, _workingTimeStain2);

            return dataForHistogram;
        }
    }
}
