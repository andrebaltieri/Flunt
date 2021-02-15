using System;
using System.Collections.Generic;

namespace Flunt.Tests.Entities
{
    public class SampleEntity
    {
        public bool BoolFalseProperty = false;
        public bool BoolTrueProperty = true;
        public bool? BoolNullProperty = null;

        public static DateTime DateTimeSnapshot = DateTime.Now;
        public DateTime DateTimeStartDate = DateTimeSnapshot.AddHours(-1);
        public DateTime DateTimeEndDate = DateTimeSnapshot.AddHours(+1);
        public DateTime DateTimeGreaterThanNow = DateTimeSnapshot.AddHours(1);
        public DateTime DateTimeGreaterOrEqualsThanNow = DateTimeSnapshot;
        public DateTime DateTimeLowerThanNow = DateTimeSnapshot.AddHours(-1);
        public DateTime DateTimeLowerOrEqualsThanNow = DateTimeSnapshot;
        public DateTime? DateTimeNull = null;
        public DateTime DateTimeBetweenStartAndEndDate = DateTimeSnapshot;
        public DateTime DateTimeNotBetweenStartAndEndDate = DateTimeSnapshot.AddHours(+5);
        public List<DateTime> DateTimeList = new List<DateTime> { DateTimeSnapshot };

        public int IntStart = 0;
        public int IntEnd = 100;
        public int? IntNull = null;
        public int IntBetweenStartAndEnd = 5;
        public int IntNotBetweenStartAndEnd = -50;
        public List<int> IntList = new List<int> { 1, 3, 5, 7, 9 };

        public double DoubleStart = 0;
        public double DoubleEnd = 100;
        public double? DoubleNull = null;
        public double DoubleBetweenStartAndEnd = 5;
        public double DoubleNotBetweenStartAndEnd = -50;
        public List<double> DoubleList = new List<double> { 1, 3, 5, 7, 9 };

        public float FloatStart = 0;
        public float FloatEnd = 100;
        public float? FloatNull = null;
        public float FloatBetweenStartAndEnd = 5;
        public float FloatNotBetweenStartAndEnd = -50;
        public List<float> FloatList = new List<float> { 1, 3, 5, 7, 9 };

        public decimal DecimalStart = 0;
        public decimal DecimalEnd = 100;
        public decimal? DecimalNull = null;
        public decimal DecimalBetweenStartAndEnd = 5;
        public decimal DecimalNotBetweenStartAndEnd = -50;
        public List<decimal> DecimalList = new List<decimal> { 1, 3, 5, 7, 9 };

        public Guid GuidEmpty = Guid.Empty;
        public Guid GuidNotEmpty = new Guid("f4ac2eab-8de5-430a-85b1-f0daa71df176");

        public IList<string> ListNull = null;
        public IList<string> ListNotNull = new List<string> { "Some item" };
        public IList<string> ListEmpty = new List<string>();
        public IList<string> ListNotEmpty = new List<string> { "Some item", "other item", "last item" };
    }
}
