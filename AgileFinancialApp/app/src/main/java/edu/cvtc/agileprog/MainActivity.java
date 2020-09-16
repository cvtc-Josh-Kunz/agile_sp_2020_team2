package edu.cvtc.agileprog;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }


    public void addUser(View view) {
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        //int id = Integer.parseInt(R.id.ed)
    }

}