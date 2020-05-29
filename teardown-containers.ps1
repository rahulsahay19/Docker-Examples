Write-Host "Deleting all containers in local Docker Host"
docker rm $(docker ps -a -q) -f