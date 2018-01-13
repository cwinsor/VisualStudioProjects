using System;
using System.Collections.Generic;
using System.Windows;

namespace Grades
{
    public class GradeBook
    {

        // public field
        private String blah;

        // auto-implemented property - the backing code is created behind the scenes
        public String Name
        {
            get;
            set;
        }

        // explicit implemented property
        public string Street
        {
            get
            {
                return Address;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    Address = value;
                }
            }
        }

        public string Blah
        {
            get
            {
                return Blah1;
            }

            set
            {
                Blah1 = value;
            }
        }

        public string Address
        {
            get
            {
                return Address1;
            }

            set
            {
                Address1 = value;
            }
        }

        public List<double> GradeList
        {
            get
            {
                return GradeList1;
            }

            set
            {
                GradeList1 = value;
            }
        }

        public string Blah1
        {
            get
            {
                return Blah2;
            }

            set
            {
                Blah2 = value;
            }
        }

        public string Address1
        {
            get
            {
                return Address2;
            }

            set
            {
                Address2 = value;
            }
        }

        public List<double> GradeList1
        {
            get
            {
                return GradeList2;
            }

                                set
            {
                GradeList2 = value;
            }
        }

        public string Blah2
        {
            get
            {
                return Blah3;
            }

            set
            {
                Blah3 = value;
            }
        }

        public string Address2
        {
            get
            {
                return Address3;
            }

            set
            {
                Address3 = value;
            }
        }

        public List<double> GradeList2
        {
            get
            {
                return GradeList3;
            }

            set    {
                GradeList3 = value;
            }
        }

        public string Blah3
        {
            get
            {
                return Blah4;
            }

            set
            {
                Blah4 = value;
            }
        }

        public string Address3
        {
            get
            {
                return Address4;
            }

            set
            {
                Address4 = value;
            }
        }

        public List<double> GradeList3
        {
            get
            {
                return GradeList4;
            }

            set      {
                GradeList4 = value;
            }
        }

        public string Blah4
        {
            get
            {
                return Blah5;
            }

            set
            {
                Blah5 = value;
            }
        }

        public string Address4
        {
            get
            {
                return Address5;
            }

            set
            {
                Address5 = value;
            }
        }

        public List<double> GradeList4
        {
            get
            {
                return GradeList5;
            }

            set
            {
                GradeList5 = value;
            }
        }

        public string Blah5
        {
            get
            {
                return blah;
            }

            set
            {
                blah = value;
            }
        }

        public string Address5
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public List<double> GradeList5
        {
            get
            {
                return gradeList;
            }

            set
            {
                gradeList = value;
            }
        }

        private string _address;

        List<Double> gradeList = new List<Double>();


        public GradeBook()
        {
        }

        public void AddGrade(double v)
        {
                        GradeList.Add(v);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics gs = new GradeStatistics();
            double sum = 0;
            foreach (Double g in GradeList)
                        {
                            gs.HighestGrade = Math.Max(g, gs.HighestGrade);
                            gs.LowestGrade = Math.Min(g, gs.LowestGrade);
                            sum += g;
                        }
            gs.AverageGrade = sum / GradeList.Count;
            return gs;
        }
    }
}