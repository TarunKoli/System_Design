## 📘 Lecture 4 — **Modern Scalable Database Design (Sharding & NoSQL)**

---

## 1️⃣ Big Picture: What a Scalable Database Looks Like

A modern large-scale database uses **horizontal partitioning (sharding)** plus **replication**.

### High-level flow

* Clients → **Router**
* Router → correct **Shard**
* Each shard → has **replicas/backups**

![Image](https://assets.digitalocean.com/articles/understanding_sharding/DB_image_3_cropped.png)

![Image](https://substackcdn.com/image/fetch/%24s_%21uef2%21%2Cf_auto%2Cq_auto%3Agood%2Cfl_progressive%3Asteep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F32d82757-8ec3-4d5b-b4a6-76a33c0f6cca_800x450.png)

![Image](https://i.sstatic.net/QgZA3.png)

### 🔑 Key Idea

* **Shard = horizontal partition of data**
* Add more shards → handle more data & traffic
* Each shard has backups → high availability

---

## 2️⃣ Why Sharding Works

Sharding allows:

* ✅ **Scalability** (add shards as traffic grows)
* ✅ **Resiliency** (if one shard fails, replica takes over)

The router decides:

* Which shard should handle a request
* Based on a **key** (e.g., userId, customerId)

📌 Example:

```
userId = 123 → hash(123) → shard #2
```

This ensures **all data for a user lives on one shard**.

---

## 3️⃣ The Join Problem in Sharded Databases

Problem:

* Data is split across shards
* **Joins across shards are expensive and complex**

### Solution

* Design data access as **key–value lookups**
* Minimize joins
* Keep related data on the **same shard**

📌 Rule of thumb:

> “If you can find data with a single key, sharding becomes easy.”

---

## 4️⃣ Example: MongoDB Architecture

![Image](https://www.mongodb.com/docs/manual/static/1112d075b61fb59a49076c865c6e8f60/bde8a/sharded-cluster-production-architecture.webp)

![Image](https://www.mongodb.com/docs/manual/images/replica-set-primary-with-two-secondaries.bakedsvg.svg)

![Image](https://www.mongodb.com/docs/manual/images/replica-set-trigger-election.bakedsvg.svg)

### Components

* **Application Servers**

  * Run `mongos` (query router)
* **Shards**

  * Each shard = **Replica Set**
  * 1 Primary + multiple Secondary nodes
* **Config Servers (≥ 3)**

  * Store shard mapping & metadata

### How It Works

* `mongos` decides which shard to use
* Primary node handles writes
* Secondaries replicate data
* If primary fails → **automatic election**

📌 Minimum **3 nodes** needed for safe leader election.

---

## 5️⃣ Key MongoDB Benefits

* Automatic failover
* Horizontal scaling
* Data survives node & data center failures

⚠️ Trade-off:

* Many servers = higher cost & maintenance

---

## 6️⃣ Alternative Approach: Apache Cassandra

### Cassandra’s Big Idea

* **No single primary**
* All nodes are equal
* Any node can accept reads & writes

### Pros

* No single point of failure
* Very high availability

### Trade-off: **Eventual Consistency**

* Writes take time to propagate
* You may not immediately read your own write

📌 Good when:

* Slight delays are acceptable
* Availability > strict consistency

---

## 7️⃣ NoSQL Databases — What It Really Means

* “NoSQL” ≠ “No SQL”
* Most NoSQL DBs:

  * Support SQL-like queries
  * Prefer **simple key-value access**
* Cross-shard joins:

  * Possible
  * Inefficient → avoid if possible

Examples:

* Amazon DynamoDB
* HBase (Hadoop ecosystem)

---

## 8️⃣ Two Big Challenges in Sharded Systems

### 🔹 Re-sharding

* Adding new shards requires **redistributing data**
* Must be:

  * Fault-tolerant
  * Online (no downtime)

### 🔹 Hotspots (Celebrity Problem)

* Some keys get far more traffic
* Example:

  * “Brad Pitt” shard gets hammered
  * Obscure actor shard is idle

📌 Modern systems:

* Monitor shard traffic
* Dynamically rebalance data

---

## 9️⃣ Normalized vs Denormalized Data

### 🔹 Normalized (Relational Style)

* Separate tables
* Use joins

**Pros**

* Less storage
* Easy updates
* Strong consistency

**Cons**

* Multiple lookups
* Joins hurt at scale

---

### 🔹 Denormalized (NoSQL Style)

* Duplicate data
* Everything stored together

![Image](https://miro.medium.com/0%2AoEboeoUu50uCoNmy.png)

![Image](https://media.geeksforgeeks.org/wp-content/uploads/20250118164445027490/denormalization.webp)

**Pros**

* One lookup per request
* Faster reads
* Scales better

**Cons**

* Hard updates
* More storage
* Eventual consistency issues

---

## 🔟 Interview-Worthy Insight (Very Important)

👉 **There is no one correct choice**

### Best Answer Pattern

1. Start **normalized** (simpler, safer)
2. Measure performance
3. **Denormalize only if needed**

📌 Interviewers want to hear:

* You understand **trade-offs**
* You design based on **real traffic patterns**
* You don’t over-engineer early

---

## 🧠 Final Takeaways (Must Remember)

* Sharding = core of scalable databases
* Routers map keys → shards
* Avoid cross-shard joins
* Prefer key–value access
* MongoDB → replica sets + elections
* Cassandra → no primary, eventual consistency
* Normalize first, denormalize when performance demands it

---

If you want next:

* 📄 **Clean markdown notes**
* 🧠 **System-design interview cheat sheet**
* ▶️ **Lecture 5 notes**
* ✏️ **One-page revision summary**
