namespace ExtensionMethodsDelegatesLambdaLINQ.LINQ
{
    // Create a class Group with properties GroupNumber and DepartmentName.
    // Introduce a property GroupNumber in the Student class.
    // Extract all students from "Mathematics" department.
    // Use the Join operator.

    public class Group
    {
        private int groupNumber;

        private string departamentName;

        public Group(int groupNumber, string departamentName)
        {
            this.GroupNumber = groupNumber;

            this.DepartamentName = departamentName;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }

        public string DepartamentName
        {
            get
            {
                return this.departamentName;
            }
            set
            {
                this.departamentName = value;
            }
        }
    }
}
