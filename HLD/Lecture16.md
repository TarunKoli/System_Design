## 📘 Lecture 16 — **How Distributed Storage Works (HDFS Deep Dive)**

---

## 1️⃣ Why Know This for Interviews?

Designing a **distributed storage system** can itself be a **system design interview question**.

Interviewers don’t expect low-level code — they expect:

* You understand **core components**
* You know **where failures can happen**
* You can explain **why it scales & stays resilient**

We’ll use **HDFS** as the concrete example.

---

## 2️⃣ What Is HDFS?

HDFS (Hadoop Distributed File System) is:

* Open-source
* Part of **Apache Hadoop**
* Designed to store **massive files** across many servers
* Typically runs in **your own data center / private cloud**

📌 Used when you want **full control** instead of managed cloud storage like S3.

---

## 3️⃣ Core Idea: Files → Blocks → Replicas

HDFS breaks files into **fixed-size blocks**:

* Typical block size: ~128 MB
* Each block is:

  * Stored on multiple machines
  * **Replicated** for fault tolerance

![Image](https://hadoop.apache.org/docs/r1.2.1/images/hdfsdatanodes.gif)

![Image](https://www.quobyte.com/wp-content/uploads/2022/09/hdfs-arch.png)

### Why Blocks?

* Enables parallel reads
* Makes storage & recovery easier
* Allows very large files

---

## 4️⃣ Rack Awareness (Very Important)

HDFS is **rack-aware**:

* Block replicas are stored on **different racks**
* Prevents data loss if:

  * A rack loses power
  * Network to a rack fails

📌 Never put all replicas in one rack ❌

---

## 5️⃣ NameNode — The Brain of HDFS

HDFS has a **master node** called the **NameNode**.

Responsibilities:

* Stores **metadata**

  * File → blocks mapping
  * Block → DataNode locations
* Knows **where data lives**
* Directs clients to the **closest replica**

📌 Clients **do not** fetch data from NameNode — only metadata.

![Image](https://hadoop.apache.org/docs/r1.2.1/images/hdfsarchitecture.gif)

![Image](https://www.simplilearn.com/ice9/free_resources_article_thumb/hdfs-metadata-namenode.jpg)

---

## 6️⃣ DataNodes — Where Data Lives

* Store actual block data
* Serve reads/writes directly to clients
* Periodically report health to NameNode

📌 If a DataNode dies:

* NameNode notices
* Re-replicates blocks elsewhere

---

## 7️⃣ Data Locality = Performance Win ⚡

HDFS is **data-locality aware**:

* Tries to place computation **where the data lives**
* Or data **where computation runs**

This avoids:

* Network hops
* Cross-rack traffic

📌 Huge performance advantage for big data processing (MapReduce, Spark).

---

## 8️⃣ Handling NameNode Failure

Problem:

* NameNode is a **logical single point of failure**

Solution:

* Multiple NameNodes
* One **active**
* Others **standby**
* Automatic leader election

![Image](https://techvidvan.com/tutorials/wp-content/uploads/sites/2/2019/11/HDFS-NameNode-High-Availbility-2-01.jpg)

![Image](https://techvidvan.com/tutorials/wp-content/uploads/2019/11/Hadoop-High-Availability-01.jpg)

📌 Downtime is usually **seconds**, not minutes.

---

## 9️⃣ Metadata Storage & Backups

Metadata (file maps, block locations):

* Stored persistently
* Replicated
* Backed up

📌 Losing metadata = losing access to data (even if blocks exist)

---

## 🔟 Why HDFS Is Resilient

HDFS survives:

* Disk failures
* Server failures
* Rack failures
* Temporary master failures

Because:

* Block replication
* Rack awareness
* Master failover
* Continuous health monitoring

---

## 🔑 Big Picture Summary

| Component      | Responsibility              |
| -------------- | --------------------------- |
| NameNode       | Metadata & coordination     |
| DataNode       | Store actual data blocks    |
| Blocks         | Fixed-size file chunks      |
| Replicas       | Fault tolerance             |
| Rack Awareness | Prevent correlated failures |
| Failover       | Master resilience           |

---

## 🧠 Interview Takeaways

Say things like:

* “Files are split into blocks and replicated.”
* “The NameNode manages metadata, not data.”
* “HDFS is rack-aware to survive rack failures.”
* “Data locality improves performance.”
* “High availability is achieved via NameNode failover.”

📌 This shows **deep but practical understanding**.

---

If you want next:

* ▶️ **Lecture 17 (MapReduce / Spark overview)**
* 🧠 **HDFS vs S3 comparison**
* 📄 **All lectures (1–16) combined notes**
* 🎯 **System design interview answers using HDFS**

Just tell me 👍
