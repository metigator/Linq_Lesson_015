namespace Shared
{
    public class Employee
    {
        public string EmployeeNo {get;set;}
        public string Name {get;set;}
         
        public override string ToString()
        {
            return $"[{EmployeeNo}] {Name}";
        }


        //public override bool Equals(object obj)
        //{
        //    if (ReferenceEquals(null, obj)) return false;
        //    if (ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != this.GetType()) return false;

        //    var other = (Employee)obj;
        //    return EmployeeNo == other.EmployeeNo && Name.Equals(other.Name);
        //}

        //public override int GetHashCode()
        //{
        //    int hash = 17; 
        //    hash = hash * 23 + EmployeeNo.GetHashCode();
        //    hash = hash * 23 + Name.GetHashCode();
        //    return hash;
        //}
    }
}
