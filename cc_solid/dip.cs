public class UserEmailer 
{
    public void SendPasswordConfirmation()
    {
        
    }
}

public class UserPresenter
{
    public void OnRequestPasswordClick()
    {
        var userEmailer = new UserEmailer();
        userEmailer.SendPasswordConfirmation();
    }
}