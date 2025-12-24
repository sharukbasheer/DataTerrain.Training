# Memento Design Pattern – Complete & Detailed Explanation (C#)

---

## 📌 Overview

The **Memento Design Pattern** is a **Behavioral Design Pattern** that allows an object to **capture and restore its internal state** without exposing its implementation details.

It is commonly used to support **undo/redo** functionality.

---

## ❓ Why the Memento Pattern Exists

### 🔴 The Problem

In applications where state changes over time:
- Undo or rollback functionality is required
- Exposing internal state breaks encapsulation
- Managing previous states becomes complex

Direct access to an object’s internal data creates tight coupling and reduces maintainability.

---

## ✅ What the Memento Pattern Solves

Memento:
- Captures an object’s state safely
- Restores state without violating encapsulation
- Separates state management from business logic

---

## 🎯 Goal of the Memento Pattern

To save and restore an object’s state **without exposing internal details**.

---

## 🧠 Core Idea

> **“Capture and restore an object’s state without breaking encapsulation.”**

---

## 🧩 Step-by-Step Explanation

1. Identify the object whose state must be saved  
2. Create a memento object to store the state  
3. Let the originator create and restore mementos  
4. Create a caretaker to manage mementos  
5. Restore state when required  

---

## 🔁 Runtime Behavior Summary

- Originator creates a memento
- Caretaker stores the memento
- Originator restores state from memento when needed

---

## ⚖️ Pros and Cons

### ✅ Advantages
- Preserves encapsulation
- Simplifies undo/redo operations
- Separates state storage logic

### ❌ Disadvantages
- Increased memory usage
- Managing many mementos can be complex

---

## 🎯 When to Use

- Undo/redo functionality is required
- State rollback is needed
- Internal state should remain hidden

---

## 🚫 When NOT to Use

- State changes are simple
- Memory usage is critical

---

## 🏢 Real-World Use Cases

- Text editors
- Configuration history
- Transaction rollback systems
- Game save checkpoints

---
