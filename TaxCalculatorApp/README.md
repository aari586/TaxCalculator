# TaxCalculator
A simple tax calculator application.

## Problem Statement
Create a library that given employee annual salary details outputs a monthly pay slip.
Attributes of the employee are:

Attributes of the monthly pay slip are:

The following annual tax rates apply:

For example, for an employee with an annual salary of $60,000:

### Here is example input:
 - name 
 - annual salary

```
• name = Blah
• gross monthly income = annual salary / 12 (months)
• monthly income tax = (annual tax rate as provided below) / 12 (months)
• net monthly income = gross monthly income - income tax
```

## Tax Details
- Taxable income 
- Tax on this income
```

$0 - $20,000 | $0
$20,001 - $40,000 | 10c for each $1 over $20,000
$40,001 - $80,000 | 20c for each $1 over $40,000
$80,001 - $180,000 | 30c for each $1 over $80,000
$180,001 and over | 40c for each $1 over $180,000
```
### Further Explanation of Calculations
```
 - gross monthly income
 = 60,000 / 12 = 5,000
 - monthly income tax
 = ((20,000 * 0) + ((40,000 - 20,000) * 0.1) + ((60,000 - 40,000) * 0.2)) / 12
 = (0 + (20,000 * 0.1) + (20,000 * 0.2)) / 12
 = (0 + 2,000 + 4,000) / 12
 = 500
 - net monthly income
 = 5,000 – 500 = 4,500
 ```

## Sample Input
`Mary Song` `60000`

### And an example of what the calculations are:

```
Monthly Payslip for: "Mary Song"
Gross Monthly Income: $5000
Monthly Income Tax: $500
Net Monthly Income: $4500
```