
internal class Users
{
    string _username;
    string _password;

    public string UserName
    {
        get => _username;
        set
        {
            if (CheckUserName(value))
            {
                _username = value;
            }
            
           
        }
    }
    public string Password {
        get => _password;
        set
        {
            if (CheckPassword(value))
            {
                _password = value;
            }
           
        }
    }



    public bool CheckPassword(string Password)
    {
        bool status=false;
        bool statuss = true;
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        if (Password.Length < 8) statuss = false;
        for (int i = 0; i < Password.Length; i++)
        {
            if (Password[i] >= 65 && Password[i] <= 90)
                            count1++;            
            if (Password[i] <= 57 && Password[i] >= 48)
                            count2++;
            if (Password[i] == 32)
                            count3++;
            if(count1>0&&count2>0&&count3==0)
                status= true;
        }

        if (status && statuss) { return true; }
        else { return false; }
    }

    public bool CheckUserName(string UserName)
    {
        bool status = true;
        for (int i = 0; i < UserName.Length; i++)
        {
            if (UserName[i] == 32)
                status = false;

        }
        return status;
    }

    public Users(string UserName, string Password)
    {
        this.UserName = UserName;
        this.Password = Password;
    }
}







