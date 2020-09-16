package edu.cvtc.agileprog;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;


import android.content.Context;
import android.content.ContentValues;
import android.database.Cursor;

import androidx.annotation.Nullable;

public class MyDBHandler extends SQLiteOpenHelper {


    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NAME = "agileDB.db";
    private static final String USER_TABLE_NAME = "User";
    public static final String USER_COLUMN_ID = "UserID";




    public MyDBHandler(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, DATABASE_NAME, factory, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
            String CREATE_USER_TABLE = "CREATE TABLE " + USER_TABLE_NAME + "(" + USER_COLUMN_ID + "INTEGER PRIMARYKEY, TEXT Username, TEXT Password )";

            db.execSQL(CREATE_USER_TABLE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {

    }

    public boolean checkLogin(String username, String password){
        SQLiteDatabase db = this.getWritableDatabase();

        String s;
        Cursor c = db.rawQuery("SELECT * FROM " + USER_TABLE_NAME + " WHERE " + username + " =? AND " + password + " =?", null);

        if (c.getCount() <= 0){
            c.close();
            db.close();
            return false;
        }else {
            c.close();
            db.close();
            return true;
        }
    }

    public void addHandler(User user) {
        ContentValues values = new ContentValues();
        values.put(USER_COLUMN_ID, user.getUserID());
        values.put("Username", user.getUserName());
        values.put("Password", user.getPassword());

        SQLiteDatabase db = this.getWritableDatabase();
        db.insert(USER_TABLE_NAME, null, values);
        db.close();
    }


}
