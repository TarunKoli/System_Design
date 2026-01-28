## 📘 Lecture 7 — **Reinforcing CAP Theorem with Real Databases**

---

## 1️⃣ Quick Recap: CAP Theorem

In distributed databases, you can **only fully guarantee 2 of 3**:

* **C — Consistency**: Reads return the latest write
* **A — Availability**: Every request gets a response
* **P — Partition Tolerance**: System works despite network failures

![Image](https://www.javacodegeeks.com/wp-content/uploads/2013/09/ae458-captheorem.png)

![Image](https://www.scylladb.com/wp-content/uploads/cap-theorem-diagram-e1647300692559.png)

📌 At scale, **Partition Tolerance is non-negotiable**, so the real trade-off is usually **Consistency vs Availability**.

---

## 2️⃣ Why MongoDB Trades Off **Availability**

### What MongoDB Guarantees

* ✅ **Consistency**
* ✅ **Partition Tolerance**
* ❌ **Availability (briefly)**

### Why Availability Is Sacrificed

MongoDB has **temporary single points of failure**:

* Primary **config server**
* Primary **replica set leader**

If a primary goes down:

1. System detects failure
2. Remaining nodes elect a new primary
3. Brief downtime (seconds)

📌 Even a few seconds = **not fully available** in CAP terms.

![Image](https://www.mongodb.com/docs/manual/images/replica-set-trigger-election.bakedsvg.svg)

![Image](https://accuweb.cloud/blog/wp-content/uploads/2024/07/mongodb-replica-set.jpg)

---

## 3️⃣ Why Apache Cassandra Trades Off **Consistency**

### What Cassandra Guarantees

* ✅ **Availability**
* ✅ **Partition Tolerance**
* ❌ **Consistency**

### Why Consistency Is Sacrificed

* No single master
* Any node can accept reads/writes
* Data is **replicated asynchronously**

Result:

* Writes take time to propagate
* Reads may return stale data temporarily

📌 This is **eventual consistency**.

![Image](https://cassandra.apache.org/_/_images/diagrams/apache-cassandra-diagrams-01.jpg)

![Image](https://docs.datastax.com/en/cassandra-oss/3.0/cassandra/images/dml_singleDCConOne.svg)

---

## 4️⃣ Comparing MongoDB vs Cassandra (CAP View)

| Database  | Consistency | Availability     | Partition Tolerance | Trade-off  |
| --------- | ----------- | ---------------- | ------------------- | ---------- |
| MongoDB   | ✅ Strong    | ❌ Brief downtime | ✅ Yes               | Gives up A |
| Cassandra | ❌ Eventual  | ✅ Always on      | ✅ Yes               | Gives up C |

---

## 5️⃣ Where Amazon DynamoDB Fits

DynamoDB is **configurable**:

* Strongly consistent reads → CP-style
* Eventually consistent reads → AP-style

📌 This flexibility is common in **modern databases**.

---

## 6️⃣ How to Choose a Database (Interview Strategy)

### Ask These First:

* How important is **availability**?

  * Is a few seconds of downtime acceptable?
* How important is **consistency**?

  * Can users see slightly stale data?
* How large does the system need to scale?

### Example Decisions:

* Payments / balances → **Consistency first**
* Social feeds / analytics → **Availability first**
* Massive scale systems → **Partition tolerance required**

---

## 7️⃣ Interview Gold Tip 🥇

Say this (or similar):

> “Since partition tolerance is required at scale, the real decision is whether the system prioritizes availability or consistency, and that depends on business requirements.”

📌 This shows **design maturity**, not tool memorization.

---

## 🔑 Final Takeaways

* MongoDB = **CP** (brief downtime acceptable)
* Cassandra = **AP** (eventual consistency acceptable)
* DynamoDB = **tunable CAP**
* CAP trade-offs are **business decisions**
* Explaining *why* you choose a DB scores more than naming one

---

If you want:

* 🧠 **CAP + database comparison cheat sheet**
* 🎯 **Interview-ready sample answers**
* 📄 **All lectures (1–7) in clean markdown**
* ▶️ **Lecture 8 notes**

Just tell me 👍
