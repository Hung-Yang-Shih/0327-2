using System;

public class Manager
{
	public readonly DateTime Startup;

	public Manager()
	{
        Startup = DateTime.Now;
    }

	public DateTime GetStarup()
	{
		return Startup;
	}
	
		}
