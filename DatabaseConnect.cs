using System;

public class DatabaseConnect()
{

	public SqlConnection myConnection;
	public SqlCommand myCommand;

	public void Connect()
	{
		string connectionString = "Trusted_Connection=yes; server=JEMISON\\SQLEXPRESS;database=291Project;connection timeout=30";
        
    SqlConnection myConnection = new SqlConnection(connectionString);

    try
    {
        myConnection.Open(); // Open connection
        myCommand = new SqlCommand();
        myCommand.Connection = myConnection; // Link the command stream to the connection
    }
    catch (Exception e)
    {
        MessageBox.Show(e.ToString(), "Error");
        this.Close();
    }
}
	}
}
