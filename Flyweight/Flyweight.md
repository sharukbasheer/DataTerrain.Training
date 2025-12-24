# Flyweight Design Pattern – Complete & Detailed Explanation (C#)

---

## 📌 Overview

The **Flyweight Design Pattern** is a **Structural Design Pattern** that minimizes memory usage by **sharing common object state** across multiple objects.

It is especially useful when a large number of similar objects are required.

---

## ❓ Why the Flyweight Pattern Exists

### 🔴 The Problem

Applications may require:
- Thousands or millions of similar objects
- High memory consumption
- Performance degradation

Storing duplicate data for each object is inefficient.

---

## ✅ What the Flyweight Pattern Solves

The Flyweight pattern:
- Shares intrinsic (common) state
- Separates extrinsic (context-specific) state
- Reduces memory usage significantly

---

## 🎯 Goal of the Flyweight Pattern

To reduce memory usage by sharing common data between multiple objects.

---

## 🧠 Core Idea

> **“Share what is common; externalize what varies.”**

---

## 🧩 Step-by-Step Explanation of the Flyweight Pattern

---

### 🔹 Step 1: Identify Shared and Non-Shared State

- **Intrinsic state**: Common, immutable, shared
- **Extrinsic state**: Context-specific, external

---

### 🔹 Step 2: Create a Flyweight Interface

This interface defines operations that use both intrinsic and extrinsic state.

---

### 🔹 Step 3: Implement Concrete Flyweights

Concrete flyweights:
- Store intrinsic state
- Are reusable
- Are immutable

---

### 🔹 Step 4: Create a Flyweight Factory

The factory:
- Manages flyweight instances
- Reuses existing objects
- Creates new ones only when necessary

---

### 🔹 Step 5: Supply Extrinsic State at Runtime

Clients:
- Pass extrinsic state to flyweights
- Avoid storing it internally

---

## 🔁 Runtime Behavior Summary

- Client requests a flyweight
- Factory returns a shared instance
- Extrinsic data is supplied externally
- Flyweight performs the operation

---

## ⚖️ Pros and Cons of the Flyweight Pattern

### ✅ Advantages
- Significant memory savings
- Improved performance
- Efficient handling of large object sets

### ❌ Disadvantages
- Increased complexity
- Requires careful state separation

---

## 🎯 When to Use the Flyweight Pattern

Use Flyweight when:
- Large numbers of similar objects exist
- Memory usage is critical
- Object state can be split

---

## 🚫 When NOT to Use the Flyweight Pattern

Avoid Flyweight when:
- Objects are few
- State separation is unclear

---

## 🏢 Real-World Use Cases

- Text editors (characters, fonts)
- Game development (trees, bullets)
- Caching systems

---
