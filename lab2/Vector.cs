using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Vector
    {
        protected List<double> vector = new List<double>();

        public Vector(double value) {
            this.vector.Add(value);
        }

        public Vector() {
            this.vector = new List<double>();
        }

        public void AddValue(double value)
        {
            this.vector.Add(value);
        }

        public List<double> ReturnValue() { 
            return this.vector;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector result = new Vector(v1.vector[0]); 
            result.vector.AddRange(v1.vector.GetRange(1, v1.vector.Count - 1)); 
            result.vector.AddRange(v2.vector); 
            return result; 
        }

        public static bool operator >(Vector v1, Vector v2) {
            return v1.vector.Count > v2.vector.Count;
        }

        public static bool operator <(Vector v1, Vector v2)
        {
            return v1.vector.Count < v2.vector.Count;
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            foreach (double value in v2.vector)
            {
                v1.AddValue(value);
            }
            return true;
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            bool flag = false;
            if (v1.vector.Count > v2.vector.Count || v1.vector.Count < v2.vector.Count) { 
                flag = false;
            }
            for (int i = 0; i < v1.vector.Count; i++) {
                if (v1.vector[i] != v2.vector[i])
                {
                    flag = false;
                }
                else {
                    flag = true;
                }
            }
            return flag;
        }

        public static Vector operator *(Vector v, double n) {
            for (int i = 0; i < v.vector.Count; i++)
            {
                v.vector[i] = ((double)v.vector[i] * n);
            }
            return v;
        }

        public static Vector Delete(Vector v) {
            for (int i = 0; i < v.vector.Count; i++)
            {
                if (v.vector[i] < 0){
                    v.vector.RemoveAt(i);
                }
            }
            return v;
        }

    }
}
