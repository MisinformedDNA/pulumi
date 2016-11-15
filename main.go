// Copyright 2016 Marapongo, Inc. All rights reserved.

package main

import (
	"flag"
	"fmt"
	"os"

	"github.com/golang/glog"

	"github.com/marapongo/mu/cmd"
)

func main() {
	// Ensure the glog library has been initialized, including calling flag.Parse beforehand.
	flag.Parse()
	glog.Info("Mu CLI is running")

	if err := cmd.Cmd.Execute(); err != nil {
		fmt.Println(err)
		os.Exit(-1)
	}
}
