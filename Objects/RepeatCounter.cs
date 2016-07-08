using System;
using System.Collections.Generic;
using System.Text;


namespace RepeatCounter.Objects
{
  public class Weekday
  {
    private int _day;
    private int _month;
    private int _year;
    private int _numberOfDays;

    private int _baseDay = 1;
    private int _baseMonth = 1;
    private int _baseYear = 1;

    public Weekday(string newDate)
    {
      string[] date = newDate.Split('/');
      _month = Int32.Parse(date[0]);
      _day = Int32.Parse(date[1]);
      _year = Int32.Parse(date[2]);
      _numberOfDays = Calcualte();
    }
    public int GetDay()
    {
      return _day;
    }
    public void SetDay(int newday)
    {
      _day = newday;
    }

    public int Calcualte()
    {
      int nthDay = 0;
      if(_month != _baseMonth)
      {

        nthDay = 30 + _day;
      }
      else
      {
        nthDay = _day - 1;
      }
      if (DateIsMoreThanAYearAway())
      {
        for(int i = _baseYear ; i < _year; i++)
        {
          nthDay += CalculateDaysInYear (i);
        }
      }

      int[] months = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
      int[] leapYearMonths = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
      if(IsLeapYear(_year)){
        for(int i=_baseMonth; i< _month-1; i++){
          nthDay += leapYearMonths[i];
        }
      }
      else{
        for(int i=_baseMonth; i< _month-1; i++){
          nthDay += months[i];
        }
      }


      return nthDay;
    }
    private bool DateIsMoreThanAYearAway()
    {
      if (_baseYear - _year < 0 || _baseYear - _year > 1)
      {
        return true;
      }
      else{
        return false;
      }
    }

    public int CalculateDaysInYear (int year)
    {
      if (IsLeapYear(year)) return 366;
      return 365;
    }

    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year % 100 == 0)
      {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }
    }

    public string Find()
    {
      string[] Weekdays = { "Monday", "Tuesday", "Wednesday","Thursday","Friday", "Saturday", "Sunday"};
      return Weekdays[_numberOfDays%7];
    }
  }

}
