docker build -f Dockerfile.test.build -t com-Anqa-service-purchasing-webapi:test-build .
docker create --name com-Anqa-service-purchasing-webapi-test-build com-Anqa-service-purchasing-webapi:test-build
mkdir bin
docker cp com-Anqa-service-purchasing-webapi-test-build:/out/. ./bin/publish
docker build -f Dockerfile.test -t com-Anqa-service-purchasing-webapi:test .
