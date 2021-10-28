namespace Memento
{
    public class Student
    {
        public string Status { get; set; }
        private Memento _memento;

        public Student()
        {
            Status = "Pending Approval";
            _memento = new Memento(Status);
        }

        public void StartAdmissionProcess()
        {
            Status = "Addmited";
        }

        public void Revert()
        {
            Status = _memento.Status;
        }
    }
}
