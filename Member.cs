public class Member {
    private string Name { get; set; }
    private string Email { get; set; }

    public Member(string name, string email) {
        Name = name;
        Email = email;
    }

    public string GetName() {
        return Name;
    }

    public string GetEmail() {
        return Email;
    }

}