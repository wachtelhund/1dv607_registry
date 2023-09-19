using System.Collections;
using Microsoft.Win32.SafeHandles;

public class Registry {
    private List<Member> memebers = new();

    public Registry() {}

    private bool IsValid(Member member){
        var found = this.memebers.Any((m) => {
            return m.GetEmail() == member.GetEmail();
        });
        if (found)
        {
            return false;
        }
        return true;
    }

    public bool Register(Member member){
        var valid = IsValid(member);
        if (valid)
        {
            this.memebers.Add(member);
            this.PrintFeedback(true, member);
            return true;
        }
        this.PrintFeedback(false, member);
        return false;
    }

    private void PrintFeedback(bool success, Member member){
        if (success)
        {
            Console.WriteLine($"Member {member.GetName()} was registered");
        }
        else
        {
            Console.WriteLine($"Member {member.GetName()} already has an existing email");
        }
    }

    public void PrintAllMembers(){
        this.memebers.ForEach((m) => {
            System.Console.WriteLine(m.GetName() + ", " + m.GetEmail());
        });
    }

}