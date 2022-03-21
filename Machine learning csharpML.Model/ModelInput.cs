using Microsoft.ML.Data;

namespace Machine_learning_csharpML.Model
{
    public class ModelInput
    {
        [ColumnName("fixed_acidity"), LoadColumn(0)]
        public float Fixed_acidity { get; set; }


        [ColumnName("volatile_acidity"), LoadColumn(1)]
        public float Volatile_acidity { get; set; }


        [ColumnName("citric_acid"), LoadColumn(2)]
        public float Citric_acid { get; set; }


        [ColumnName("residual_sugar"), LoadColumn(3)]
        public float Residual_sugar { get; set; }


        [ColumnName("chlorides"), LoadColumn(4)]
        public float Chlorides { get; set; }


        [ColumnName("free_sulfur_dioxide"), LoadColumn(5)]
        public float Free_sulfur_dioxide { get; set; }


        [ColumnName("total_sulfur_dioxide"), LoadColumn(6)]
        public float Total_sulfur_dioxide { get; set; }


        [ColumnName("density"), LoadColumn(7)]
        public float Density { get; set; }


        [ColumnName("pH"), LoadColumn(8)]
        public float PH { get; set; }


        [ColumnName("sulphates"), LoadColumn(9)]
        public float Sulphates { get; set; }


        [ColumnName("alcohol"), LoadColumn(10)]
        public string Alcohol { get; set; }


        [ColumnName("quality"), LoadColumn(11)]
        public float Quality { get; set; }


        [ColumnName("type"), LoadColumn(12)]
        public string Type { get; set; }
    }
}
