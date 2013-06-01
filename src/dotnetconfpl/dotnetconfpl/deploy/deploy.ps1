Task Default -depends Deploy

Task Deploy -depends Build {
   "Deploy"
}

Task Build{
   "Build"
}