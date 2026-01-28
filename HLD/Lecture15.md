## 📘 Lecture 15 — **Distributed Storage for Massive Data**

---

## 1️⃣ Why Distributed Storage Is Needed

In large systems, data is often:

* **Unstructured** (CSV, JSON, logs)
* **Huge** (TB → PB)
* **Growing continuously**

You can’t store this on a single machine.
You need **massively distributed storage**.

📌 Typical use cases:

* Data lakes
* Logs & analytics
* Static assets (images, HTML, CSS)
* Backups
* Big data pipelines

![Image](https://www.researchgate.net/publication/221397122/figure/fig1/AS%3A670014235475969%401536755250007/Distributed-Object-Storage-system-architecture.png)

![Image](https://www.researchgate.net/publication/294581592/figure/fig1/AS%3A669018960719882%401536517958598/Object-storage-system.ppm)

---

## 2️⃣ What We Want from Distributed Storage

A good solution must be:

* **Scalable** → virtually infinite storage
* **Highly available** → data always accessible
* **Durable** → data is not lost
* **Secure** → access control & encryption
* **Fast enough** → acceptable read latency

📌 You don’t usually build this yourself — you **choose** an existing system.

---

## 3️⃣ Data Lakes & Raw Storage (Recap)

Distributed storage is often the **first stop** for data:

* Raw logs
* CSV / JSON files
* Event streams
* Images & media

Later:

* Structure is added
* Data is queried or processed
* Results may go into databases or warehouses

---

## 4️⃣ Durability & SLAs (Very Important)

### Example: **Amazon S3**

* **11 nines durability**
  (99.999999999%)
* Data is replicated automatically
* Losing data is *extremely* unlikely

📌 Durability ≠ availability
Your data might exist, but still be temporarily unreachable.

---

## 5️⃣ Understanding SLAs (Service Level Agreements)

### 🔹 Durability SLA

* Probability your data **will not be lost**
* Example: S3 → almost zero chance of loss

### 🔹 Latency SLA

* Percentile-based
* Example:

  * *99.9% of requests return within 100ms*

### 🔹 Availability SLA (Often Misunderstood)

* **99% availability ≠ good**

  * ~3.65 days downtime/year ❌
* **99.9999% (6 nines)** ≈ ~30 seconds/year ✅

📌 Always convert percentages into **real downtime**.

---

## 6️⃣ Storage Tiers: Hot, Cool & Cold

### 🔥 Hot Storage

* Fast access
* Expensive
* Frequently used data

### ❄️ Cool Storage

* Slower
* Cheaper
* Infrequent access

### 🧊 Cold Storage

* Very slow retrieval
* Cheapest
* Archival data

Example (AWS):

* S3 Standard → Hot
* S3 Infrequent Access → Cool
* Glacier → Cold archive

![Image](https://miro.medium.com/v2/resize%3Afit%3A1200/0%2AZfhmHUnMSpW1YojA.jpg)

![Image](https://www.cloudkeeper.com/cms-assets/s3fs-public/2023-07/diagram%203.png)

📌 Trade-off = **cost vs access speed**

---

## 7️⃣ Cost Optimization Strategies

You can save money by:

* Choosing lower durability for non-critical data
* Using cold storage for archives
* Accepting slower access times
* Reducing replication if backups exist elsewhere

📌 Storage design is also a **business decision**.

---

## 8️⃣ Popular Distributed Storage Options

### Cloud Providers

* **Amazon S3**
* **Google Cloud Storage**
* **Azure Blob Storage**

### Self-Managed / Open Source

* **HDFS**

  * Part of Hadoop
  * Run on your own servers
  * More ops effort

![Image](https://hadoop.apache.org/docs/r1.2.1/images/hdfsarchitecture.gif)

![Image](https://storage.googleapis.com/gweb-cloudblog-publish/images/Cloud_Storage.max-1300x1300.png)

---

## 9️⃣ What NOT to Use in System Design

Consumer tools like:

* Dropbox
* Google Drive
* iCloud
* OneDrive

❌ Not designed for large-scale programmatic access
❌ Not suitable for backend system design

---

## 🔑 Interview Takeaways

* Massive data → **distributed object storage**
* Data lakes store raw data first
* Durability SLAs matter
* Availability percentages can be misleading
* Hot / cool / cold storage = cost optimization
* Pick tools based on **data access patterns**

📌 Saying *“I’d start with S3 / object storage for raw data”* is almost always a good answer.

---

If you want next:

* ▶️ **Lecture 16 (HDFS & Hadoop deep dive)**
* 🧠 **Big data storage comparison cheat sheet**
* 📄 **Complete notes (Lectures 1–15)**
* 🎯 **Interview answers for data-heavy systems**

Just say 👍
