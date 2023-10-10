package com.example.mylibrary;

public class WilliamsLogger {

    static final String LOGTAG = "WilliamsLOG";

    static WilliamsLogger _instance = null;

    public static WilliamsLogger getInstance()
    {
        if (_instance == null)
            _instance = new WilliamsLogger();
        return _instance;
    }

    public String getLogtag()
    {
        return LOGTAG;
    }
}
