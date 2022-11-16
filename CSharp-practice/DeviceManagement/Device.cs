using System;

namespace DeviceManagement
{
    public class Device
    {
        private int id;
        private string name;
        private string manufacturer;
        private string importedDate;

        public Device(int id, string name, string manufacturer, string importedDate)
        {
            this.id = id;
            this.name = name;
            this.manufacturer = manufacturer;
            this.importedDate = importedDate;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string ImportedDate
        {
            get { return importedDate; }
            set { importedDate = value; }
        }
    }

    public class DeviceManagement
    {
        void input()

        void display()
    }
}

