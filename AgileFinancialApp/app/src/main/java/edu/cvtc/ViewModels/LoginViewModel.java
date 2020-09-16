package edu.cvtc.ViewModels;

import androidx.lifecycle.ViewModel;
import edu.cvtc.Models.UserModel;
import edu.cvtc.Services.AppServices;
import edu.cvtc.agileprog.User;

public class LoginViewModel extends ViewModel {

    private AppServices _appServices;

    public LoginViewModel(){
        _appServices = new AppServices();
    }

    @Bindable
    private String usernameText;
    public String getUsernameText(){
        return usernameText;
    }

    @Bindable
    private String passwordText;
    public String getPasswordText(){
        return passwordText;
    }

    //This is the method used when the user clicks the login button.
    public void OnLoginClick(){
        //get username from text box
        String username = getUsernameText();

        //get password from text box
        String password = getPasswordText();

        //check if the user exists
        UserModel user = _appServices.GetUserByCredentials(username, password);
        if(user == null) return;

        //open the main view with the new user

    }

    //This is the method used when the user clicks on the create user button.
    public void OnCreateUserClick(){
        //get username from text box
        String username = getUsernameText();

        //get password from text box
        String password = getPasswordText();

        //create a new record with these new credentials
    }
}
