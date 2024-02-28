pipeline {
    agent any
    
    environment {
        // Set environment variables if needed
        DOCKER_COMPOSE_VERSION = '1.29.2' // Specify the version of Docker Compose you want to use
        COMPOSE_FILE_PATH = '/var/jenkins_home/workspace/CICDWithJenkinsfile/docker-compose.yml' // Path to your docker-compose.yml file
    }

    stages {
        stage('Checkout') {
            steps {
                // Clean workspace before cloning
                deleteDir()

                // Clone the GitHub repository
                checkout scm
                // sh "sudo cp -r . $PATH_PROJECT"
                // echo "Checked out code to: $PATH_PROJECT"
            }
        }

        stage('Setup Environment') {
            steps {
                script {
                    // Install Docker Compose
                    sh "curl -L https://github.com/docker/compose/releases/download/\${DOCKER_COMPOSE_VERSION}/docker-compose-\$(uname -s)-\$(uname -m) -o /usr/local/bin/docker-compose"
                    sh 'chmod +x /usr/local/bin/docker-compose'

                    // Print Docker Compose version
                    sh 'docker-compose --version'
                }
            }
        }

        stage('Build and Run') {
            steps {
                script {
                    // Run Docker Compose
                    sh "docker-compose -f ${COMPOSE_FILE_PATH} up -d"
                }
            }
        }

        // Add more stages as needed

        stage('Cleanup') {
            steps {
                script {
                    // Stop and remove Docker Compose services
                    sh "docker-compose -f ${COMPOSE_FILE_PATH} down"
                }
            }
        }
    }

    post {
        success {
            echo 'Pipeline completed successfully!'
        }
        failure {
            echo 'Pipeline failed! Check logs for details.'
        }
    }
}
