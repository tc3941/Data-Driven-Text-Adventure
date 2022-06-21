using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    public class MyKeyValuePair<K>
    {
        K key;
        K value1;
        K value2;
        K value3;
        K value4;
        K value5;
        K value6;
        public MyKeyValuePair(K k, K v1, K v2, K v3, K v4, K v5, K v6)
        {
            key = k;
            value1 = v1;
            value2 = v2;
            value3 = v3;
            value4 = v4;
            value5 = v5;
            value6 = v6;
        }
        public MyKeyValuePair()
        {

        }

        public K GetKey()
        {
            return key;
        }
        public K GetValue1()
        {
            return value1;
        }
        public K GetValue2()
        {
            return value2;
        }
        public K GetValue3()
        {
            return value3;
        }
        public K GetValue4()
        {
            return value4;
        }
        public K GetValue5()
        {
            return value5;
        }
        public K GetValue6()
        {
            return value6;
        }
        public void SetKey(K v1)
        {
            key = v1;
        }

        public void SetVal(int num,K v1)
        {
            switch (num)
            {
                case 0: SetValue1(v1);break;
                case 1:SetValue2(v1);break;
                case 2:SetValue3(v1);break;
                case 3:SetValue4(v1);break;
                case 4:SetValue5(v1);break;
                case 5:SetValue6(v1);break;
                default:throw new System.ArgumentOutOfRangeException("Parameter cannot be higher than 5 or less than 0.");
            }
        }
        public void SetValue1(K v1)
        {
            value1 = v1;
        }
        public void SetValue2(K v1)
        {
            value2 = v1;
        }
        public void SetValue3(K v1)
        {
            value3 = v1;
        }
        public void SetValue4(K v1)
        {
            value4 = v1;
        }
        public void SetValue5(K v1)
        {
            value5 = v1;
        }
        public void SetValue6(K v1)
        {
            value6 = v1;
        }
        public override string ToString()
        {
            return "Key: " + GetKey() + ", Values: " + GetValue1() + ", " + GetValue2() + ", " + GetValue3() + ", " + GetValue4() + ", " + GetValue5() + ", " + GetValue6() + ".";
        }
    }
}
