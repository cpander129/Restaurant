using System;
using System.Collections;

public class Employee
{
    private String id, fName, lName;
    private bool order, manage, loggedIn;
    private DateTime signIn, signOut;
    #region Setters
    public void SetId(String id)
    {
        this.id = id;
    }

    public void SetFName(String fName)
    {
        this.fName = fName;
    }

    public void SetLName(String lName)
    {
        this.lName = lName;
    }

    public void SetOrder(bool order)
    {
        this.order = order;
    }

    public void SetManage(bool manage)
    {
        this.manage = manage;
    }

    public void SetLoggedIn(bool loggedIn)
    {
        this.loggedIn = loggedIn;
    }

    public void SetSignIn(DateTime signIn)
    {
        this.signIn = signIn;
    }

    public void SetSignOut(DateTime signOut)
    {
        this.signOut = signOut;
    }
    #endregion
    #region Getters
    public String GetId()
    {
        return id;
    }

    public String GetFName()
    {
        return fName;
    } 

    public String GetLName()
    {
        return lName;
    }

    public bool IsOrder()
    {
        return order;
    }

    public bool IsManage()
    {
        return manage;
    }

    public bool IsLoggedIn()
    {
        return loggedIn;
    }

    public DateTime GetSignIn()
    {
        return signIn;
    }

    public DateTime GetSignOut()
    {
        return signOut;
    }
    #endregion
    public Employee(String id, String fName, String lName, bool order, bool manage)
	{
        this.SetId(id);
        this.SetFName(fName);
        this.SetLName(lName);
        this.SetOrder(order);
        this.SetManage(manage);
	}

    public void LogIn(String id)
    {
        this.SetLoggedIn(true);
        this.SetSignIn(DateTime.now);
    }

    public void LogOut(String id)
    {
        this.SetLoggedIn(false);
        this.SetSignOut(DateTime.Now);
    }
}
