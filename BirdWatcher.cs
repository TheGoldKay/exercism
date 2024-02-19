using System;

class BirdCount
{
    private int[] birdsPerDay;
    private int today;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
        this.today = birdsPerDay.Length - 1;
    }

    public static int[] LastWeek()
    {
        int[] last = {0, 2, 5, 3, 7, 8, 4};
        return last;
    }

    public int Today()
    {
        return this.birdsPerDay[this.today];
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[this.today]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int day in this.birdsPerDay)
        {
            if(day == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for(int day = 0; day < numberOfDays; day++)
        {
            sum += this.birdsPerDay[day];
        }
        return sum;
    }

    public int BusyDays()
    {
        int busy = 0;
        foreach(int day in this.birdsPerDay)
        {
            if(day >= 5)
            {
                busy++;
            }
        }
        return busy;
    }
}
