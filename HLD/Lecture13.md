## 📘 Lecture 13 — **Deep Dive into Resiliency & Global Failure Handling**

---

## 1️⃣ Resiliency Is Not Optional at Scale

In massive systems:

* Servers **fail frequently**
* Failures are **expected**, not rare
* Design must answer: *“What happens when things go wrong?”*

📌 Interviewers **expect you to plan for failure**.

---

## 2️⃣ Failure Can Happen at Many Levels

It’s not just about one server dying.

Possible failure scopes:

* ❌ Single server (CPU, disk, memory failure)
* ❌ Entire rack (power/network issue)
* ❌ Data center / Availability Zone
* ❌ Entire region (network partition, outage)
* ❌ Continent-level network isolation

![Image](https://substackcdn.com/image/fetch/f_auto%2Cq_auto%3Agood%2Cfl_progressive%3Asteep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F50d6ff61-09a2-493d-84e1-59c2568fd611_2250x2800.png)

![Image](https://s3-us-west-1.amazonaws.com/foscoshopify/graphics/pictures/fd990b402354_8B9E/image_thumb_7.png)

---

## 3️⃣ Data Replication Is the First Line of Defense

Never store important data in one place.

Example:

* **MongoDB**

  * Primary database
  * One or more secondary replicas
  * Automatic failover if primary dies

📌 This protects against **single-node failures**, not large disasters.

---

## 4️⃣ What If a Whole Region Goes Down?

Failures aren’t always hardware-related:

* Network partitions
* Routing issues
* Undersea cable cuts
* ISP-level outages

📌 Servers may be healthy, but **unreachable**.

So we must design for **regional failure**.

---

## 5️⃣ Geo-Routing & Multi-Region Architecture

Instead of:

* One global load balancer

We use:

* **Geo-aware routing (usually DNS-based)**

Traffic routing example:

* North America users → NA region
* Europe users → EU region
* India users → India region

![Image](https://storage.googleapis.com/gweb-cloudblog-publish/images/2_DNS_resolution.max-1000x1000.jpg)

![Image](https://docs.aws.amazon.com/images/whitepapers/latest/real-time-communication-on-aws/images/inter-region-ha-design.png)

### If Europe Goes Down:

* DNS stops routing traffic to Europe
* Traffic rerouted to nearest healthy region
* Higher latency, but **system stays up**

📌 **Degraded performance is better than downtime**

---

## 6️⃣ Over-Provisioning Is Required

To survive a region failure:

* Remaining regions must handle **extra traffic**
* You must assume **one region can disappear**

That means:

* Extra servers
* Extra cost
* Extra operational complexity

📌 Resilience = **paying for unused capacity**

---

## 7️⃣ Distribute Backups Correctly

Bad design:

* Primary + backup on same rack ❌

Good design:

* Replicas across:

  * Different racks
  * Different availability zones
  * Different regions

![Image](https://learn.microsoft.com/en-us/azure/well-architected/design-guides/_images/regions-availability-zones/zonal-multiple-zones.png)

![Image](https://d2908q01vomqb2.cloudfront.net/887309d048beef83ad3eabf2a79a64a389ab1c9f/2020/04/10/Best-practices-cross-Region-read-replicas-A.png)

📌 Each layer protects against a larger failure.

---

## 8️⃣ Availability Zones & Regions

Cloud providers abstract physical infrastructure:

* **Availability Zones**
  ≈ isolated data centers
* **Regions**
  ≈ geographic areas

Providers like **Amazon** and **Google** design systems assuming:

* AZ failures are common
* Region failures are rare but possible

---

## 9️⃣ Cost vs Resiliency Trade-off 💰

Not every system needs extreme resiliency.

Ask these questions:

* Is downtime acceptable?
* For how long?
* What’s the business impact?

Examples:

* Internal tool → minutes of downtime OK
* Global consumer platform → downtime unacceptable

📌 Companies like **Facebook** or Amazon:

* Will pay **any price** to avoid downtime
* Always over-provision

---

## 🔑 Interview Framing (Very Important)

Say things like:

* “I’d distribute replicas across racks, AZs, and regions.”
* “We assume one region can fail at any time.”
* “This requires over-provisioning, which increases cost.”

📌 Shows **real-world engineering judgment**.

---

## 🧠 Final Takeaways

* Failures happen constantly at scale
* Plan for:

  * Server
  * Rack
  * Data center
  * Region failure
* Use geo-routing & multi-region deployments
* Replicate data across fault domains
* Over-provision to survive worst-case failures
* Resiliency is a **business decision**, not just technical

---

If you want:

* 🧠 **Resiliency interview cheat sheet**
* 🎯 **Sample answers for region failure questions**
* 📄 **Complete notes (Lectures 1–13)**
* ▶️ **Next lecture notes**

Just say 👍
