## 📘 Lecture 11 — **CDNs (Content Delivery Networks) & Global Caching**

---

## 1️⃣ Why CDNs Exist

When your application serves users **globally**, distance matters.

* Users are spread across:

  * US, Europe, India, Asia-Pacific, etc.
* Long distances = **high latency**
* Speed of light is a hard limit 🌍

📌 Hitting a server in the US from Japan is slow — **CDNs solve this**.

---

## 2️⃣ What Is a CDN?

A **Content Delivery Network (CDN)** is:

* A **globally distributed network of servers**
* Located at **edge locations** close to users
* Used mainly to serve **static content**

Examples of content served by CDNs:

* Images
* CSS
* JavaScript
* Static HTML
* Video chunks

![Image](https://developers.cloudflare.com/_astro/ref-arch-cdn-figure3.CcIfEHZq_1mhfV1.svg)

![Image](https://res.cloudinary.com/hy4kyit2a/f_auto%2Cfl_lossy%2Cq_70/learn/modules/aws-application-deployment-and-monitoring/learn-about-the-content-delivery-network/images/aac1432369ffa63e2b0acd7b8826c333_a-2443665-5320-4-d-9-f-855-d-8-cd-07769-b-509.png)

---

## 3️⃣ How CDNs Fit into System Architecture

### Without CDN

User → Internet → Load Balancer → App → DB
❌ Long latency for distant users

### With CDN

User → **Nearest Edge Location**
✔ Fast response
✔ Less load on origin servers

![Image](https://substackcdn.com/image/fetch/%24s_%21rycF%21%2Cf_auto%2Cq_auto%3Agood%2Cfl_progressive%3Asteep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2Fd2785489-6c63-40cf-bb4a-1b8656a81d01_1600x1104.png)

![Image](https://miro.medium.com/v2/resize%3Afit%3A814/1%2AxIHqmjx0AyerN8sdzWBMxQ.png)

The CDN:

* Automatically routes users to nearest edge
* Syncs content with the origin
* Handles cache invalidation & freshness

---

## 4️⃣ What Should Go on a CDN?

Best candidates:

* Static assets (images, JS, CSS)
* Media files (videos, thumbnails)
* Public, read-heavy content

⚠️ Usually **not**:

* Dynamic user-specific data
* Frequently changing transactional data

📌 In interviews: say *“static assets & media”*.

---

## 5️⃣ CDNs Can Do More (But Usually Don’t)

Some CDNs offer:

* Edge compute
* ML model execution
* Request filtering

📌 Mostly used for **static delivery**, not business logic.

---

## 6️⃣ Cost Trade-offs 💰

CDNs are **powerful but expensive**:

* Global servers cost money
* Cross-region bandwidth is costly
* Certain regions (e.g., China) are very expensive

📌 Design question to ask:

> “What absolutely needs to be on the CDN?”

Example:

* Designing YouTube → videos must be on CDN
* But maybe metadata doesn’t need global replication

---

## 7️⃣ Popular CDN Providers

### Cloud Providers

* **AWS CloudFront**
* **Google Cloud CDN**
* **Azure CDN**

### Dedicated CDNs

* **Akamai**
* **Cloudflare**

![Image](https://d1.awsstatic.com/onedam/marketing-channels/website/aws/en_US/global-infrastructure/approved/images/cloudfront-pop-static-map.b64acf5738108c84936643c3dda57ae2e52a27e1.jpg)

![Image](https://static.seekingalpha.com/uploads/2020/10/18/318104-16030510750604336_origin.png)

![Image](https://developers.cloudflare.com/_astro/ref-arch-cdn-figure5.B3Tq_F2z_Z1zLO2B.svg)

📌 Competitive market → better pricing & features.

---

## 8️⃣ Interview-Worthy Talking Points 🧠

Say things like:

* “I’d put static assets on a CDN to reduce latency.”
* “CDNs help meet global SLAs.”
* “Not all data belongs on a CDN due to cost.”

---

## 🔑 Final Takeaways

* CDNs reduce **latency for global users**
* Serve data from **edge locations**
* Best for static & read-heavy content
* Cost matters — be selective
* Essential tool for global-scale systems

---

If you want:

* 🧠 **CDN vs cache comparison**
* 🎯 **System design interview examples (YouTube, Netflix)**
* 📄 **Complete notes (Lectures 1–11)**
* ▶️ **Lecture 12 notes**

Just tell me 👍
