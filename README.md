# MS_CertAuthority
## What is it
Web Portal for Self Service against a Microsoft Certificate Authority

The Microsoft Certificate Authority is pretty good, and serves the requirements for many organisations. However, the provided web interface is dire, and really not fit for Self Service.

This project tries to change that, with a new portal!

## Requirements
- IIS
- .NET 4.5
- An existing Microsoft Certificate Authority

## Installing
Download, compile and deploy into a new Website on a Domain Joined web server.
Modify the web.config and add in your CA server details.
Change the App Pool to run as a user account that has rights to issue certificates.
