using System;


namespace DataModel
{
     public class Program
    {
        public static void Main()
        {

            

        }
    }

    public class TestingModel
    {
        public string model_name { get; set; }
        public string[] barcodes;
        public Lamps[] lamps;


        public TestingModel()
        {
            model_name = string.Empty;
            barcodes = new string[4];
            lamps = new Lamps[5];
        }

    }
    public class Lamps
    {
        public string lamp_name { get; set; }
        public Voltage voltage { get; set; }

        public Current current { get; set; }

        public Lamps()
        {
            voltage = new Voltage();
            current = new Current();
            lamp_name = string.Empty;

        }



    }
    public class Voltage
    {
        public float[] test_voltage { get; set; }
        public float[] min_voltage { get; set; }
        public string[] max_voltage { get; set; }
        public float[] offset_voltage { get; set; }
        public Voltage()
        {
            offset_voltage = new float[3];
            max_voltage = new string[3];
            min_voltage = new float[3];
            test_voltage = new float[3];
        }

    }
    public class Current
    {
        public float[] test_current = new float[3];
        public float[] min_current = new float[3];
        public float[] max_current = new float[3];
        public float[] offset_current = new float[3];

    }




}

