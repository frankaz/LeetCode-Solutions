// 1491. Average Salary Excluding the Minimum and Maximum Salary
// Level: Easy
// https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/

public class Solution
{
  public double Average(int[] salary)
  {
    double totalSalary = salary.Sum();
    double maxSalary = salary.Max();
    double minSalary = salary.Min();

    return (totalSalary - maxSalary - minSalary) / (salary.Length - 2);
  }
}