# Observer-Singleton-State

Project carried out during the fourth session of my software development program.


## Project Specification

The goal was to use design patterns to structure the project.

### Stock Market

Your program must model the stock price of a company, which fluctuates randomly over time. The stock price should randomly fluctuate by ±$0.05 every minute. A stock price must have a value, a code, a company name, and the address of the headquarters.

### Buying and Selling Based on a Profile

To maximize profits, a person relies on an investor profile to make buying and selling decisions.

| Profile            | Decision                                                                                |
| ------------------- | --------------------------------------------------------------------------------------- |
| Small Budget        | Buy: Price decrease of at least 10% compared to the 20-day moving average. Buys with 90% of the budget. <br> Sell: Price increase of at least 10% compared to the 20-day moving average. <br> After a sale or purchase, wait at least one day before another transaction. <br> Commission: $30 <br> Balance: < $500,000 |
| Average Income      | Buy: Price decrease of at least 5% compared to the 20-day moving average. Buys with 75% of the budget. <br> Sell: Price increase of at least 5% compared to the 20-day moving average. <br> After a sale or purchase, wait at least one day before another transaction. <br> Commission: $10 <br> Balance: $500,000 - $1,000,000 |
| Bill Gates          | Buy: Price decrease of at least 3% compared to the 20-day moving average. Buys with 60% of the budget. <br> Sell: Price increase of at least 3% compared to the 20-day moving average. <br> After a sale or purchase, wait at least one day before another transaction. <br> Commission: $5 <br> Balance: > $1,000,000 |

### Compare the Algorithm for Multiple People

However, not all investors start investing at the same time. The first investor will invest from year zero to the 10th year. The second investor will invest from the first year to the 10th year. The third investor will invest from the second year to the 10th year. At the end of the program execution, the profits (losses) should be displayed on the screen for each of the investors. Additionally, the program must determine who made the most profit.

The goal is to determine which of the three investors will have the most profit after 10 years of investment (from the first investor). Initially, all three investors are registered in the system.

### Initialization Value

At the beginning, a person has $12,000 and relies on the initial value of the stock when entering ($5) to make investment decisions.
