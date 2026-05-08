# Weight-Balanced Binary Tree

A C# implementation of a self-balancing binary search tree. This project demonstrates an efficient approach to maintaining tree equilibrium using height estimation and periodic rebalancing, ensuring consistent performance even with random or skewed data.



## Features

The WeightBalancedTree class provides a robust API for hierarchical data management:
* **Self-Balancing**: Automatically triggers a rebalance when the tree height exceeds the $2\log n$ threshold.
* **Core Operations**: Fully supports Insert, Remove, Build, and Clear.
* **Flexible Estimation**: Implements height estimation logic (configurable via left-path, right-path, or random-path sampling) to minimize overhead.

## Performance Analysis

The tree maintains an optimal height of $O(\log n)$, providing the following complexities:

| Operation | Time Complexity | Space Complexity |
| :--- | :--- | :--- |
| **Insert / Search** | $O(\log n)$ | $O(1)$ |
| **Balance / Build** | $O(n)$ | $O(n)$ |
| **Clear** | $O(1)$ | $O(1)$ |

*Note: Rebalancing is performed amortized over n operations to maintain high throughput.*

---

## Installation & Build

This is a **C# Console-Mode Project** targeting modern .NET.

1. **Requirements**: Visual Studio 2022 or newer / .NET SDK.
2. **Setup**: Open the solution file (.sln) in Visual Studio.
3. **Build**: Use Ctrl+Shift+B to compile.
4. **Run**: Press F5 to execute the demonstration, which inserts random integers and displays the balanced output.

## Quality Assurance

Comprehensive **Unit Tests** are included to verify:
* Tree integrity after insertions and removals.
* Rebalancing triggers when height thresholds are crossed.
* Accurate path-based height estimation.
