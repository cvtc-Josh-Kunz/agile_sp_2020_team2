package edu.cvtc.Services;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;


import android.content.Context;
import android.content.ContentValues;
import android.database.Cursor;

import edu.cvtc.Models.UserModel;

import java.util.List;

public class AppServices extends SQliteOpenHelper implements IAppServices{

    public enum Environment{
        Live,
        Develop,
        QA
    }

    public final String USERS_TABLE = "Users";

    public final String LIVE_DATABASE_NAME = "Financial_db.db";
    public final String DEVELOP_DATABASE_NAME = "Dev_Financial_db.db";
    public final String QA_DATABASE_NAME = "QA_Financial_db.db";

    private Environment CurrentEnvironment;

    public AppServices(Environment environment){
        this.CurrentEnvironment= environment;
    }

    public UserModel GetUserByCredentials(String username, String password){
        //call the database for username/password and if there is a record matching return true.
        String sql = String.format("Select * FROM %s WHERE username = %s AND password = %s;");

        return null;
    }

    public List<Object> GetExpensesForUserId(int userID){
        return null;
    }

    private void CreateDatabase(){

    }
}
