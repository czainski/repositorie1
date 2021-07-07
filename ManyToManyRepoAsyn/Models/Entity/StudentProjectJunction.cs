namespace ManyToManyCore.Models {

    public class StudentProjectJunction 
    {
        public long Id { get; set; }
	    //
        public long ProjectId  { get; set; }
        public Project Project  { get; set; }
        //
        public long StudentId  { get; set; }
        public Student Student { get; set; }
    }
}
