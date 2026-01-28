## 📘 Lecture 6 — **ACID Properties & the CAP Theorem**

---

## 1️⃣ What Is ACID Compliance?

ACID describes **guarantees a database provides for transactions**. Interviewers expect you to know these.

### 🔹 **A — Atomicity**

* A transaction **fully succeeds or fully fails**
* No partial writes, no half-finished data
* If any step fails → **rollback everything**

📌 Example:
Money transfer → debit + credit
If credit fails, debit is undone.

---

### 🔹 **C — Consistency (ACID meaning)**

* Database rules are **always enforced**
* Invalid data is rejected

📌 Example:
If balance cannot be negative → transaction fails if it tries to make it negative.

⚠️ **Important:**
This is **NOT** the same “consistency” used in CAP Theorem.

---

### 🔹 **I — Isolation**

* Concurrent transactions **don’t interfere**
* One transaction doesn’t see partial changes of another

📌 Prevents:

* Dirty reads
* Weird intermediate states

---

### 🔹 **D — Durability**

* Once committed, data **will not be lost**
* Survives crashes, power failures

📌 Stored on durable storage (disk, replicated storage)

---

## 2️⃣ ACID vs Scalability

Traditional relational databases:

* Strong ACID guarantees
* Harder to scale horizontally

Examples:

* **Oracle**
* **MySQL**

👉 At massive scale, **something often has to be sacrificed**.

---

## 3️⃣ CAP Theorem (The Big Trade-off)

CAP says a distributed system can guarantee **only two** of the following three:

* **C — Consistency**
  Read returns the latest write
* **A — Availability**
  Every request gets a response (no single point of failure)
* **P — Partition Tolerance**
  System keeps working even if network splits occur

![Image](https://media.geeksforgeeks.org/wp-content/uploads/20240813184051/cap.png)

![Image](https://miro.medium.com/1%2ArxTP-_STj-QRDt1X9fdVlA.png)

📌 You must **choose 2 out of 3**.

---

## 4️⃣ Mapping Real Databases to CAP

### 🔹 CA (Consistency + Availability)

* Single-node or limited distribution
* Poor horizontal scalability

Examples:

* **MySQL**
* **Oracle**

✔ Immediate reads
❌ Hard to partition at scale

---

### 🔹 AP (Availability + Partition Tolerance)

* No single point of failure
* Scales extremely well
* **Eventual consistency**

Example:

* **Apache Cassandra**

✔ Always available
✔ Horizontally scalable
❌ Reads may be stale briefly

---

### 🔹 CP (Consistency + Partition Tolerance)

* Strong consistency
* Accepts **brief downtime** during failures

Examples:

* **MongoDB**
* **Amazon DynamoDB** (configurable)

✔ Correct data
✔ Scalable
❌ Temporary unavailability during failover

---

## 5️⃣ Eventual Consistency (Key Concept)

* Writes **propagate over time**
* Reads immediately after write may return old data

📌 Acceptable when:

* Likes, views, analytics
* Social feeds
* Logs & metrics

❌ Not acceptable for:

* Banking balances
* Payments
* Inventory counts (usually)

---

## 6️⃣ Modern Reality (Important Interview Insight)

* CAP is a **guiding model**, not a hard rule
* Modern databases blur boundaries:

  * Tunable consistency
  * Fast leader elections
  * Multi-region replication

📌 Example:

* DynamoDB lets you choose:

  * Strong consistency
  * Eventual consistency

---

## 7️⃣ How to Answer in Interviews (Golden Pattern)

1. Explain **ACID**
2. Clarify **Consistency ≠ CAP consistency**
3. State CAP trade-offs
4. Choose based on **business requirements**

📌 Sample line:

> “Partition tolerance is non-negotiable at scale, so the real choice is between availability and consistency.”

---

## 🔑 Final Takeaways

* ACID = transaction correctness
* CAP = distributed system trade-offs
* Consistency means **two different things**
* Large systems **must be partition tolerant**
* Database choice depends on **what you’re willing to sacrifice**
* Showing trade-off awareness = strong system design signal

---

If you want next:

* 🧠 **One-page ACID + CAP cheat sheet**
* 🎯 **Interview-ready answers**
* 📄 **Complete markdown notes (Lecture 1–6)**
* ▶️ **Next lecture notes**

Just say the word 👍
