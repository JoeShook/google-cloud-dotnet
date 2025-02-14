# Version history

## Version 1.0.0-alpha05, released 2024-01-08

### New features

- Added PSC config, PSC interface config, PSC instance config ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))
- Added two boolean fields satisfies_pzi and satisfies_pzs ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))
- Added instance network config ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))
- Added ListDatabases API and Database object ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))
- Changed field network in NetworkConfig from required to optional ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))

### Documentation improvements

- Clarified read pool config is for read pool type instances ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))

## Version 1.0.0-alpha04, released 2023-09-25

### New features

- Added enum value for PG15 ([commit 92f51da](https://github.com/googleapis/google-cloud-dotnet/commit/92f51da889998ff8160a5bd778ff07d89d01f636))
- Deprecate network field in favor of network_config.network ([commit 92f51da](https://github.com/googleapis/google-cloud-dotnet/commit/92f51da889998ff8160a5bd778ff07d89d01f636))
- Added ClientConnectionConfig ([commit 92f51da](https://github.com/googleapis/google-cloud-dotnet/commit/92f51da889998ff8160a5bd778ff07d89d01f636))
- Added DatabaseVersion ([commit 92f51da](https://github.com/googleapis/google-cloud-dotnet/commit/92f51da889998ff8160a5bd778ff07d89d01f636))

## Version 1.0.0-alpha03, released 2023-07-25

### New features

- Add metadata exchange support for AlloyDB connectors ([commit 5bd7231](https://github.com/googleapis/google-cloud-dotnet/commit/5bd723164f63b63d9bd260ffd7a77b5ab29a1ac8))
- Adds metadata field describing an AlloyDB backup's quantity based retention ([commit 5bd7231](https://github.com/googleapis/google-cloud-dotnet/commit/5bd723164f63b63d9bd260ffd7a77b5ab29a1ac8))

## Version 1.0.0-alpha02, released 2023-06-20

### Bug fixes

- Deprecated SSL modes SSL_MODE_ALLOW, SSL_MODE_REQUIRE, SSL_MODE_VERIFY_CA ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))

### New features

- Added ClusterView supporting more granular view of continuous backups ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added new SSL modes ALLOW_UNENCRYPTED_AND_ENCRYPTED, ENCRYPTED_ONLY ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added users API ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added fault injection API ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added instance update policy ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added cluster network config ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))

### Documentation improvements

- Minor formatting in description of AvailabilityType ([commit 324516f](https://github.com/googleapis/google-cloud-dotnet/commit/324516f3b1e3284afeb1f18f265a89c592aea2ff))

## Version 1.0.0-alpha01, released 2023-03-01

Initial release.


