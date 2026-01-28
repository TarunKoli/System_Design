## 📘 Lecture 5 — **Data Lakes, Big Data & Serverless Analytics**

---

## 1️⃣ Database vs Data Lake (High-Level)

In big data systems, you’ll often hear **data lake** instead of database.

### 🔹 Data Lake

* A **large, centralized storage** for raw data
* Data can be:

  * Logs (unstructured)
  * CSV (semi-structured)
  * JSON (structured)
* Stored **as-is**, without enforcing schema upfront

📌 Think: *“Dump everything now, structure later.”*

![Image](https://res.cloudinary.com/hevo/images/c_scale%2Cw_448%2Ch_291%2Cdpr_2.625/f_webp%2Cq_auto%3Abest/v1685957898/hevo-learn-1/Data-Lake/Data-Lake.png?_i=AA)

![Image](https://s7280.pcdn.co/wp-content/uploads/2017/09/Data-Lake-vs-Data-Warehouse-vs-Database-Explained.png)

---

## 2️⃣ Where Data Lakes Usually Live

Most commonly: **Amazon S3**

### Why S3?

* Virtually infinite storage
* Pay only for what you use
* Built-in durability & replication
* Ideal for raw, append-only data

📌 Perfect for logs, events, analytics data.

---

## 3️⃣ Adding Structure to Raw Data

Raw data alone isn’t very useful — **structure is required to query it**.

### 🔹 AWS Glue

**AWS Glue**

* Crawls data in S3
* Infers schema (columns, data types)
* Creates a **metadata catalog**

📌 Turns a “data dump” into something queryable.

---

## 4️⃣ Querying the Data Lake (Serverless Analytics)

### 🔹 Amazon Athena

**Amazon Athena**

* SQL queries directly on S3
* Fully serverless
* Pay per query

### 🔹 Amazon Redshift & Spectrum

**Amazon Redshift**

* Distributed data warehouse
* **Redshift Spectrum** lets you query S3 directly
* Hybrid between:

  * Traditional warehouse
  * Data lake querying

![Image](https://miro.medium.com/v2/resize%3Afit%3A1200/1%2AMIbLBofXvyEkasVQ-_5jxQ.png)

![Image](https://d2908q01vomqb2.cloudfront.net/b6692ea5df920cad691c20319a6fffd7a4a766b8/2017/07/18/redshift_spectrum-1.gif)

---

## 5️⃣ Why Data Lakes Are Popular

* No need to design DB schema upfront
* Cheap at scale
* Off-the-shelf, highly scalable
* Cloud provider handles:

  * Replication
  * Failures
  * Scaling

📌 In interviews: mentioning these shows **practical system design awareness**.

---

## 6️⃣ Still Need Partitioning (Very Important)

Even in data lakes, **partitioning matters for performance**.

### Example: Log Analytics

If users often query:

* “Logs from yesterday”
* “Logs from last month”

👉 Partition data by **date**

### Common Pattern

```
/logs/
 └── year=2026/
     └── month=01/
         └── day=16/
```

![Image](https://www.persistent.com/wp-content/uploads/2019/02/Organization-of-data-in-S3.png)

![Image](https://i0.wp.com/dennyglee.com/wp-content/uploads/2024/01/data-partitioning-splash.png?fit=1684%2C2118\&ssl=1)

### Benefits

* Faster queries
* Less data scanned
* Lower cost

---

## 7️⃣ Designing from the User Backwards

Key design principle:

> **Start from query patterns, then design partitions**

Examples:

* Query by date → partition by date
* Query by store → partition by store
* Can combine:

  * Date + store
  * Region + customer

📌 Same idea as sharding — but applied to files.

---

## 8️⃣ Typical Data Lake Architecture

1. Raw data → **S3**
2. Schema discovery → **Glue**
3. SQL queries → **Athena / Redshift Spectrum**

![Image](https://docs.aws.amazon.com/images/architecture-diagrams/latest/data-lake-architecture-for-renewable-energy/images/data-lake-architecture-for-renewable-energy.png)

![Image](https://docs.aws.amazon.com/images/whitepapers/latest/aws-serverless-data-analytics-pipeline/images/da-pipeline.png)

---

## 🔑 Key Takeaways (Must Remember)

* **Data Lake ≠ Database**
* Store raw data first, structure later
* S3 + Glue + Athena is a common pattern
* Serverless analytics reduces ops overhead
* Partitioning is critical for performance
* Design partitions based on **user queries**
* Mentioning off-the-shelf solutions in interviews = 👍

---

If you want next:

* 🧠 **One-page Big Data cheat sheet**
* 📄 **Clean markdown notes**
* 🎯 **System design interview answers using data lakes**
* ▶️ **Next lecture notes**

Just tell me 👍
